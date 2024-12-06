INSERT INTO tFakulte (fakulteID, fakulteAd) VALUES
(1, 'M�hendislik'),
(2, 'E�itim'),
(3, 'Sa�l�k');

INSERT INTO tBolum (bolumID, bolumAd, fakulteID) VALUES
(101, 'Bilgisayar', 1),
(102, 'Elektrik', 1),
(103, '�n�aat', 1),
(201, 'E�itim', 2),
(202, 'MatematikFen', 2),
(203, 'T�rk�eSosyal', 2),
(301, 'Hem�irelik', 3),
(302, 'Fizyoterapi', 3),
(303, 'Beslenme', 3);

INSERT INTO tOgrenci (ogrenciID, ad, soyad, bolumID) VALUES
(101002, 'Ay�e', 'Kara', 101),
(101003, 'Mehmet', 'Demir', 101),
(102001, 'Fatma', '�elik', 102),
(102002, 'Ahmet', '�ahin', 102),
(102003, 'Elif', 'G�ne�', 102),
(103001, 'Merve', 'Y�ld�z', 103),
(103002, 'Burak', 'Kaya', 103),
(103003, 'Deniz', 'Ayd�n', 103),
(201001, 'Zeynep', 'Er', 201),
(201002, 'Ali', 'Polat', 201),
(201003, 'Ay�enur', 'Y�lmaz', 201),
(202001, 'Kemal', 'Tuna', 202),
(202002, 'Leyla', 'Kara', 202),
(202003, 'Onur', 'Ta�', 202),
(203001, 'Serap', '�etin', 203),
(203002, 'Burak', '�elik', 203),
(203003, 'Ece', '�al��kan', 203),
(301001, 'Selin', 'Ak', 301),
(301002, 'Emre', 'Kaya', 301),
(301003, 'H�lya', 'Y�lmaz', 301),
(302001, 'Mehmet', '�zt�rk', 302),
(302002, 'Ay�e', '�ahin', 302),
(302003, 'Ali', 'Ko�', 302),
(303001, 'Fatma', 'Kara', 303),
(303002, 'Elif', 'Y�ld�r�m', 303),
(303003, 'Ahmet', 'Demir', 303);
