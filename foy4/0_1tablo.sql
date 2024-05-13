create table client_master
(
client_no varchar(6) PRIMARY KEY,
name varchar(20),
address1 varchar(30),
address2 varchar(30),
city varchar(15),
state varchar(15),
pincode int,
bal_due float
)
create table Product_master
(
Product_no varchar(6) PRIMARY KEY,
Description varchar(15),
Profit_percent float,
Unit_measure varchar(10),
Qty_on_hand int,
Reorder_lvl int,
Sell_price int,
Cost_price int
)
create table Salesman_Master
(
Salesman_no VARCHAR(6) PRIMARY KEY,
CONSTRAINT sb CHECK (Salesman_no like 'S%'),
Sal_name varchar(20) NOT NULL,
Address varchar(30) NOT NULL,
City varchar(20),
State varchar(20),
Pincode int,
Sal_amt int NOT NULL CHECK (Sal_amt != 0),
Tgt_to_get int NOT NULL CHECK (Tgt_to_get != 0),
Ytd_sales int NOT NULL CHECK (Ytd_sales != 0),
Remarks varchar(30)
)
create table Sales_Order
(
S_order_no varchar(6) PRIMARY KEY,
CONSTRAINT ob CHECK (S_order_no like '0%'),
S_order_date date,
Client_no varchar(6) FOREIGN KEY REFERENCES client_master,
Dely_add varchar(6),
Salesman_no varchar(6) FOREIGN KEY REFERENCES Salesman_Master(Salesman_no),
Dely_type char(1) CHECK (Dely_type IN('P', 'F')) DEFAULT 'F',
Billed_yn char(1),
Dely_date date,
CONSTRAINT more CHECK (Dely_date >= S_order_date),
Order_status varchar(10) CHECK (Order_status IN('in process', 'fulfilled', 'back order', 'canceled'))
)
create table Sales_Order_Details
(
S_order_no varchar(6) FOREIGN KEY REFERENCES Sales_Order(S_order_no),
Product_no varchar(6) FOREIGN KEY REFERENCES Product_master(Product_no),
Qty_order int,
Qty_disp int,
Product_rate float
)