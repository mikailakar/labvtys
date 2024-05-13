select client_master.name, Product_master.Description from Sales_Order 
right join Sales_Order_Details on Sales_Order_Details.S_order_no = Sales_Order.S_order_no 
left join Product_master on Product_master.Product_no = Sales_Order_Details.Product_no 
left join client_master on client_master.client_no = Sales_Order.Client_no
 where DATEDIFF(day, S_order_date, CURRENT_TIMESTAMP) > 10