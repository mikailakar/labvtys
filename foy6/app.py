from flask import Flask, render_template, request, redirect, url_for, jsonify
from pymongo import MongoClient
import redis
import json

app = Flask(__name__)

mongo_client = "mongodb+srv://huseyinakar:huseyinakar@cluster0.amtsxza.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0"
mongo_db = MongoClient(mongo_client)
db = mongo_db.get_database('sample_mflix')

redis_client = redis.StrictRedis(host='localhost', port=6379, db=0, decode_responses=True)

@app.route('/')
def index():
    mongo_data = list(db.foy.find())
    redis_keys = redis_client.keys('*')
    redis_data = [{'key': key, 'value': json.loads(redis_client.get(key)) if redis_client.get(key) else ''} for key in redis_keys]
    return render_template('index.html', mongo_data=mongo_data, redis_data=redis_data)

@app.route('/mongo/create', methods=['GET', 'POST'])
def create_mongo():
    if request.method == 'POST':
        key = request.form['key']
        value = request.form['value']
        db.foy.insert_one({'key': key, 'value': value})
        return redirect(url_for('index'))
    return render_template('create.html', db_type='mongo')

@app.route('/mongo/edit/<key>', methods=['GET', 'POST'])
def edit_mongo(key):
    if request.method == 'GET':
        data = db.foy.find_one({'key': key})
        return render_template('update.html', db_type='mongo', key=key, value=data['value'])
    elif request.method == 'POST':
        new_value = request.form['value']
        db.foy.update_one({'key': key}, {'$set': {'value': new_value}})
        return redirect(url_for('index'))

@app.route('/mongo/delete/<key>', methods=['GET', 'POST'])
def delete_mongo(key):
    if request.method == 'GET':
        data = db.foy.find_one({'key': key})
        return render_template('delete.html', db_type='mongo', key=key, value=data['value'])
    elif request.method == 'POST':
        db.foy.delete_one({'key': key})
        return redirect(url_for('index'))

@app.route('/redis/create', methods=['GET', 'POST'])
def create_redis():
    if request.method == 'POST':
        key = request.form['key']
        value = request.form['value']
        redis_client.set(key, json.dumps(value))
        return redirect(url_for('index'))
    return render_template('create.html', db_type='redis')

@app.route('/redis/edit', methods=['GET', 'POST'])
def edit_redis():
    key = request.args.get('key')
    if request.method == 'GET':
        value = redis_client.get(key)
        if value:
            value = json.loads(value)
        return render_template('update.html', db_type='redis', key=key, value=value)
    elif request.method == 'POST':
        new_value = request.form['value']
        if redis_client.exists(key):
            redis_client.set(key, json.dumps(new_value))
            return redirect(url_for('index'))
        else:
            return "Data not found", 404

@app.route('/redis/delete', methods=['GET', 'POST'])
def delete_redis():
    key = request.args.get('key')
    if request.method == 'GET':
        value = redis_client.get(key)
        if value:
            value = json.loads(value)
        return render_template('delete.html', db_type='redis', key=key, value=value)
    elif request.method == 'POST':
        if redis_client.exists(key):
            redis_client.delete(key)
            return redirect(url_for('index'))
        else:
            return "Data not found", 404

if __name__ == '__main__':
    app.run(debug=True)
