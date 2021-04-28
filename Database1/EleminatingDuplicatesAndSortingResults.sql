-- Display a list of product colors
select Distinct isnull(Color, 'None') AS Color From SalesLT.Product;
-- Display a list of product colors with the 
select Distinct isnull(Color, 'None') AS Color, isnull(Size, '-') As Size  From SalesLT.Product;

select Name, Listprice from SalesLT.Product order by ProductNumber offset 0 rows fetch next 10 rows only;

select Name, Listprice from SalesLT.Product order by ProductNumber offset 10 rows fetch next 10 rows only;
