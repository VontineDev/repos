
-- Union example
SELECT FirstName, LastName, 'Employee' as Type
FROM SalesLT.Employees
UNION ALL
SELECT FirstName, LastName, 'Customer'
FROM SalesLT.Customers
ORDER BY LastName;
GO

-- Call each customer once per product
select p.Name,c.FirstName, c.LastName, c.Phone
from SalesLT.Product as p
cross join SalesLT.Customer as c
GO
