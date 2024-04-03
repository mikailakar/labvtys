create table birimler
(
birim_id int PRIMARY KEY NOT NULL,
birim_ad char(25) NOT NULL
)
create table calisanlar
(
calisan_id INT PRIMARY KEY NOT NULL,
ad char(25) NULL,
soyad char(25) NULL,
maas int NULL,
katilmaTarihi datetime NULL,
calisan_birim_id int FOREIGN KEY REFERENCES birimler NOT NULL
)
create table unvan
(
unvan_calisan_id int FOREIGN KEY REFERENCES calisanlar NOT NULL,
unvan_calisan char(25) NULL,
unvan_tarih datetime NULL
)
create table ikramiye
(
ikramiye_calisan_id int FOREIGN KEY REFERENCES calisanlar NOT NULL,
ikramiye_ucret int NULL,
ikramiye_tarih datetime NULL
)
