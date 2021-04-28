-- Null numbers = 0
SELECT Name, ISNULL(TRY_CAST (Size As Integer),0) AS NumericSize
FROM SalesLT.Product;

-- Null strings = blank string
SELECT ProductNumber, ISNULL(Color,'') + ',' + ISNULL(Size,'') As ProductDetails
FROM SalesLT.Product;

-- find first non-null date
SELECT Name, Coalesce(DiscontinuedDate, SellEndDate, SellStartDate) As LastActivity
From SalesLT.Product;

-- Searched Case
Select Name,
		CASE	
			WHEN SellEndDate IS NULL THEN 'On Sale'
			Else 'Discontinued'
		END AS SalesStatus
From SalesLT.Product;

-- Simple case
SELECT Name,
		CASE Size	
			WHEN 'S' THEN 'Small'
			WHEN 'M' THEN 'Medium'
			WHEN 'L' THEN 'Large'
			WHEN 'XL' THEN 'Extra-Large'
			ELSE ISNULL(Size, 'n/a')
		END AS ProductSize
FROM SalesLT.Product;


-- finish the query
SELECT  SalesOrderNumber + ' (' + STR(RevisionNumber, 1) + ')' AS OrderRevision,
	   CONVERT(NVARCHAR(30), OrderDate, 102) AS OrderDate
FROM SalesLT.SalesOrderHeader;