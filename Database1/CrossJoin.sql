-- Call each customer once per product
select p.Name,c.FirstName, c.LastName, c.Phone
from SalesLT.Product as p
cross join SalesLT.Customer as c
