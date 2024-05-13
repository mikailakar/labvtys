create view gunlukSiparis as
select * from Sales_Order where DATEDIFF(day, S_order_date, CURRENT_TIMESTAMP) = 0;