create table Sube
(
sube_id int PRIMARY KEY NOT NULL,
sube_adi NVARCHAR(20) NOT NULL,
adres NVARCHAR(20) NOT NULL,
)

create table Calisan
(
calisan_no int PRIMARY KEY NOT NULL,
ad NVARCHAR(20) NOT NULL,
soyad NVARCHAR(20) NOT NULL,
maas int NOT NULL,
adres NVARCHAR(20) NOT NULL,
gorev NVARCHAR(20) NOT NULL,
sube_id int FOREIGN KEY REFERENCES Sube NOT NULL,
)

create table Yonetici
(
yonetici_no int PRIMARY KEY NOT NULL,
calisan_no int FOREIGN KEY REFERENCES Calisan NOT NULL,
sube_id int FOREIGN KEY REFERENCES Sube NOT NULL,
)

create table Stok
(
urid int PRIMARY KEY NOT NULL,
adet int NOT NULL,
gram DECIMAL(12,2) NOT NULL,
sube_id int FOREIGN KEY REFERENCES Sube NOT NULL,
)

create table Musteri
(
mid int PRIMARY KEY NOT NULL,
ad NVARCHAR(20) NOT NULL,
adres NVARCHAR(20) NOT NULL,
)

create table Siparis
(
siid int PRIMARY KEY NOT NULL,
tarih DATETIME NOT NULL,
durum int NOT NULL,
mid int FOREIGN KEY REFERENCES Musteri NOT NULL,
)

create table Recete
(
rid int PRIMARY KEY NOT NULL,
siid int FOREIGN KEY REFERENCES Siparis NOT NULL,
urid int FOREIGN KEY REFERENCES Stok NOT NULL,
adet int NOT NULL,
)