create view SalesLT.vProductModelCatalogDescription2
AS
select p.ProductID, p.Name as ProductName, pm.Name as ProductModelName
from SalesLT.Product as p
JOIN SalesLT.ProductModel as pm
ON p.ProductModelID = pm.ProductModelID

--select * 
--from SalesLT.vProductModelCatalogDescription2


DECLARE @varColors table
(ProductID integer,
Name varchar(50),
Color varchar(20)) 
insert into @varColors
select distinct ProductID, Name, Color
from SalesLT.Product
select * from @varColors

select * from dbo.ufnGetAllCategories() ;

select Company, Revenue
from 
(select c.CompanyName as Company , c.Phone, oh.TotalDue as Revenue
from SalesLT.SalesOrderHeader as oh
join SalesLT.Customer as c
on oh.CustomerID = c.CustomerID) as CustomerSalesRevenue

SELECT CompanyContact, SUM(SalesAmount) AS Revenue
FROM
	(SELECT concat(c.CompanyName, concat(' (' + c.FirstName + ' ', c.LastName + ')')), SOH.TotalDue
	 FROM SalesLT.SalesOrderHeader AS SOH
	 JOIN SalesLT.Customer AS c
	 ON SOH.CustomerID = c.CustomerID) AS CustomerSales(CompanyContact, SalesAmount)
GROUP BY CompanyContact
ORDER BY CompanyContact;