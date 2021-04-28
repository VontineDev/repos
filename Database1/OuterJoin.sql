--Get all customers, with sales orders for thos who've bought anyting
select c.FirstName, c.LastName, oh.SalesOrderNumber
from SalesLT.Customer as c
left outer join SalesLT.SalesOrderHeader as oh
on c.CustomerID = oh.CustomerID
order by c.CustomerID;

-- Return only customers who haven't purchased anything
select c.FirstName, c.LastName, oh.SalesOrderNumber
from SalesLT.Customer as c
left outer join SalesLT.SalesOrderHeader as oh
on c.CustomerID = oh.CustomerID
where oh.SalesOrderNumber is null
order by c.CustomerID;

-- More than 2 tables
select p.Name as ProductName, oh.SalesOrderNumber
from SalesLT.Product as p
left join SalesLT.SalesOrderDetail as od
on p.ProductID = od.ProductID
left join SalesLT.SalesOrderHeader as oh --Additional tables added to the right must also use
on od.SalesOrderID = oh.SalesOrderID
order by p.ProductID;

select p.Name as ProductName, c.Name as Category, oh.SalesOrderNumber
from SalesLT.Product as p
left join SalesLT.SalesOrderDetail as od
on p.ProductID = od.ProductID
left join SalesLT.SalesOrderHeader as oh --Additional tables added to the right must also use
on od.SalesOrderID = oh.SalesOrderID
inner join SalesLT.ProductCategory as c
on p.ProductCategoryID = c.ProductCategoryID
order by p.ProductID;

select p.Name as ProductName, c.Name as Category, oh.SalesOrderNumber
from SalesLT.Product as p
inner join SalesLT.ProductCategory as c
on p.ProductCategoryID = c.ProductCategoryID
left join SalesLT.SalesOrderDetail as od
on p.ProductID = od.ProductID
left join SalesLT.SalesOrderHeader as oh --Additional tables added to the right must also use
on od.SalesOrderID = oh.SalesOrderID
order by p.ProductID;

