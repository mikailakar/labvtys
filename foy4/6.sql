create table sorualti
(
ID int PRIMARY KEY,
isim varchar(15) NOT NULL,
soyisim varchar(15),
CONSTRAINT tek UNIQUE(isim, soyisim),
yas int DEFAULT 20
)