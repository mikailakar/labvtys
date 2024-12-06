create table tFakulte(
fakulteID int Primary Key,
fakulteAd varchar(15)
)
create table tBolum(
bolumID int Primary Key,
bolumAd varchar(15),
fakulteID int foreign key references tFakulte
)
create table tOgrenci(
ogrenciID int Primary Key,
ad varchar(15),
soyad varchar(15),
bolumID int foreign key references tBolum
)
create table tOgrenciDers(
ogrenciDersId int IDENTITY(1,1) Primary Key,
ogrenciID int foreign key references tOgrenci,
dersID int,
yil int,
yariyil int,
vize int,
final int
)