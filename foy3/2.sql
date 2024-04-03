INSERT INTO birimler
  (birim_id, birim_ad)
VALUES
  (1, 'Yazýlým'),
  (2, 'Donaným'),
  (3, 'Güvenlik');

INSERT INTO calisanlar
  (calisan_id, ad, soyad, maas, katilmaTarihi, calisan_birim_id)
VALUES
  (1, 'Ýsmail', 'Ýþeri', 100000, '20140220', 1),
  (2, 'Hami', 'Satýlmýþ', 80000, '20140611', 1),
  (3, 'Durmuþ', 'Þahin', 300000, '20140220', 2),
  (4, 'Kaðan', 'Yazar', 500000, '20140220', 3),
  (5, 'Meryem', 'Soysaldý', 500000, '20140611', 3),
  (6, 'Duygu', 'Akþehir', 200000, '20140611', 2),
  (7, 'Kübra', 'Seyhan', 75000, '20140120', 1),
  (8, 'Gülcan', 'Yýldýz', 90000, '20140411', 3);

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
  (1, 'Yönetici', '20160220'),
  (2, 'Peronel', '20160611'),
  (8, 'Personel', '20160611'),
  (5, 'Müdür', '20160611'),
  (4, 'Yönetici Yardýmcýsý', '20160611'),
  (7, 'Personel', '20160611'),
  (6, 'Takým Lideri', '20160611'),
  (3, 'Takým Lideri', '20160611');