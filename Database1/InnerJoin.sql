-- Basic inner join
select SalesLT.Product.Name as ProductName, SalesLT.ProductCategory.Name as Category
from SalesLT.Product
inner join SalesLT.ProductCategory
on SalesLT.Product.ProductCategoryID = SalesLT.ProductCategory.ProductCategoryID;

-- Table aliases
select p.Name as ProductName, c.Name as Category
from SalesLT.Product as p
inner join SalesLT.ProductCategory as c
on p.ProductCategoryID = c.ProductCategoryID;

-- Joining more than 2 tables
select oh.OrderDate, oh.SalesOrderNumber, p.Name as ProductName, od.OrderQty, od.UnitPrice, od.LineTotal
from SalesLT.SalesOrderHeader as oh
join SalesLT.SalesOrderDetail as od
on od.SalesOrderID = oh.SalesOrderID
join SalesLT.Product as p
on od.ProductID = p.ProductID
order by oh.OrderDate, oh.SalesOrderID, od.SalesOrderDetailID;

-- Multiple join predicates
select oh.OrderDate, oh.SalesOrderNumber, p.Name as ProductName, od.OrderQty, od.UnitPrice, od.LineTotal
from SalesLT.SalesOrderHeader as oh
join SalesLT.SalesOrderDetail as od
on od.SalesOrderID = oh.SalesOrderID
join SalesLT.Product as p
on od.ProductID = p.ProductID and od.UnitPrice < p.ListPrice --Note multiple predicates
order by oh.OrderDate, oh.SalesOrderID, od.SalesOrderDetailID;