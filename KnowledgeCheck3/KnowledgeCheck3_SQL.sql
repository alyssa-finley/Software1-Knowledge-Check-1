--Select the Customer Name for the OrderID 10310
SELECT C.CustomerName
FROM Customers C
INNER JOIN Orders O 
	ON O.CustomerId = C.CustomerID 
WHERE O.OrderID = 10310;

SELECT S.Address
FROM Suppliers S 
INNER JOIN Products P 
	ON P.SupplierID = S.SupplierID 
WHERE P.ProductID = 40;