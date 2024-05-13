create view product_view(pro_no, [desc], profit, Unit_measure, qty) as
select Product_no, Description, Profit_percent, Unit_measure, Qty_on_hand from Product_master;