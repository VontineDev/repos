-- CAST
SELECT CAST (ProductID AS varchar(5)) + ':' + Name As ProductName
FROM SalesLT.Product;

--CONVERT
SELECT CONVERT (varchar(5),ProductID) + ':' + Name As ProductName
FROM SalesLT.Product;

-- Convert dates
select SellStartDate,
	CONVERT (nvarchar(30), SellStartDate) As ConvertedDate,
	CONVERT (nvarchar(30), SellStartDate, 126) As ISO8601FormatDate
From SalesLT.Product;

-- Try to Cast
SELECT Name, TRY_CAST (Size As Integer) AS NumericSize
FROM SalesLT.Product;
