INSERT INTO birimler
  (birim_id, birim_ad)
VALUES
  (1, 'Yaz�l�m'),
  (2, 'Donan�m'),
  (3, 'G�venlik');

INSERT INTO calisanlar
  (calisan_id, ad, soyad, maas, katilmaTarihi, calisan_birim_id)
VALUES
  (1, '�smail', '��eri', 100000, '20140220', 1),
  (2, 'Hami', 'Sat�lm��', 80000, '20140611', 1),
  (3, 'Durmu�', '�ahin', 300000, '20140220', 2),
  (4, 'Ka�an', 'Yazar', 500000, '20140220', 3),
  (5, 'Meryem', 'Soysald�', 500000, '20140611', 3),
  (6, 'Duygu', 'Ak�ehir', 200000, '20140611', 2),
  (7, 'K�bra', 'Seyhan', 75000, '20140120', 1),
  (8, 'G�lcan', 'Y�ld�z', 90000, '20140411', 3);

INSERT INTO ikramiye
  (ikramiye_calisan_id, ikramiye_ucret, ikramiye_tarih)
VALUES
  (1, 5000, '20160220'),
  (2, 3000, '20160611'),
  (3, 4000, '20160220'),
  (1, 4500, '20160220'),
  (2, 3500, '20160611');
  
INSERT INTO unvan
  (unvan_calisan_id, unvan_calisan, unvan_tarih)
VALUES
  (1, 'Y�netici', '20160220'),
  (2, 'Peronel', '20160611'),
  (8, 'Personel', '20160611'),
  (5, 'M�d�r', '20160611'),
  (4, 'Y�netici Yard�mc�s�', '20160611'),
  (7, 'Personel', '20160611'),
  (6, 'Tak�m Lideri', '20160611'),
  (3, 'Tak�m Lideri', '20160611');