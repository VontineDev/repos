--List information about product model 6
select Name, Color, Size from SalesLT.Product where ProductModelID <> 6;


select productnumber, Name, ListPrice from SalesLT.Product where ProductNumber like '%R%';

select ProductNumber, ListPrice from SalesLT.Product where ProductNumber like 'FR-_[0-9][0-9]_-[0-9][0-9]';

select Name from SalesLT.Product where SellEndDate IS NOT NULL;

select Name from SalesLT.Product where SellEndDate BETWEEN '2006/1/1' AND '2006/12/31';

--find products that have a catergory ID of 5, 6, or 7;
select ProductCategoryID, Name, ListPrice from SalesLT.Product where ProductCategoryID IN(5,6,7);

select ProductCategoryID, Name, ListPrice from SalesLT.Product where ProductCategoryID IN(5,6,7) AND SellEndDate IS NULL;

select ProductCategoryID, Name, ListPrice from SalesLT.Product where ProductNumber LIKE 'FR%' OR ProductCategoryID IN(5,6,7) order by ProductCategoryID asc;