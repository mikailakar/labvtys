INSERT INTO tFakulte (fakulteID, fakulteAd) VALUES
(1, 'Mühendislik'),
(2, 'Eðitim'),
(3, 'Saðlýk');

INSERT INTO tBolum (bolumID, bolumAd, fakulteID) VALUES
(101, 'Bilgisayar', 1),
(102, 'Elektrik', 1),
(103, 'Ýnþaat', 1),
(201, 'Eðitim', 2),
(202, 'MatematikFen', 2),
(203, 'TürkçeSosyal', 2),
(301, 'Hemþirelik', 3),
(302, 'Fizyoterapi', 3),
(303, 'Beslenme', 3);

INSERT INTO tOgrenci (ogrenciID, ad, soyad, bolumID) VALUES
(101002, 'Ayþe', 'Kara', 101),
(101003, 'Mehmet', 'Demir', 101),
(102001, 'Fatma', 'Çelik', 102),
(102002, 'Ahmet', 'Þahin', 102),
(102003, 'Elif', 'Güneþ', 102),
(103001, 'Merve', 'Yýldýz', 103),
(103002, 'Burak', 'Kaya', 103),
(103003, 'Deniz', 'Aydýn', 103),
(201001, 'Zeynep', 'Er', 201),
(201002, 'Ali', 'Polat', 201),
(201003, 'Ayþenur', 'Yýlmaz', 201),
(202001, 'Kemal', 'Tuna', 202),
(202002, 'Leyla', 'Kara', 202),
(202003, 'Onur', 'Taþ', 202),
(203001, 'Serap', 'Çetin', 203),
(203002, 'Burak', 'Çelik', 203),
(203003, 'Ece', 'Çalýþkan', 203),
(301001, 'Selin', 'Ak', 301),
(301002, 'Emre', 'Kaya', 301),
(301003, 'Hülya', 'Yýlmaz', 301),
(302001, 'Mehmet', 'Öztürk', 302),
(302002, 'Ayþe', 'Þahin', 302),
(302003, 'Ali', 'Koç', 302),
(303001, 'Fatma', 'Kara', 303),
(303002, 'Elif', 'Yýldýrým', 303),
(303003, 'Ahmet', 'Demir', 303);
