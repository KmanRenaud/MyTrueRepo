/* joins: select all the computers from the products table:
using the products table and the categories table, return the product name and the category name */
 SELECT p.name, c.name
 FROM products p
 inner join categories c
 on p.CategoryID = c.CategoryID;	
/* joins: find all product names, product prices, and products ratings that have a rating of 5 */
SELECT p.name, p.Price, r.Rating
 FROM products p
 inner join reviews r
 on p.ProductID = r.ProductID
 WHERE r.Rating = 5;	
/* joins: find the employee with the most total quantity sold.  use the sum() function and group by */
SELECT  e.EmployeeID, e.FirstName, SUM(s.Quantity) AS Quantity_Sold, SUM(s.PricePerUnit)
FROM employees e
inner join sales s
on e.EmployeeID = s.EmployeeID
GROUP BY s.EmployeeID
ORDER BY Quantity_Sold DESC;

/* joins: find the name of the department, and the name of the category for Appliances and Games */
SELECT d.Name, c.Name
FROM categories c 
INNER JOIN departments d
ON c.DepartmentID = d.DepartmentID
WHERE c.Name = "Appliances" OR c.name = "Games";
/* joins: find the product name, total # sold, and total price sold,
 for Eagles: Hotel California --You may need to use SUM() */
SELECT p.name, SUM(s.Quantity), SUM(S.Quantity * s.pricePerUnit)
FROM products p
INNER JOIN sales s
ON p.ProductID = s.ProductID
WHERE s.ProductID = 97;
/* joins: find Product name, reviewer name, rating, and comment on the Visio TV. (only return for the lowest rating!) */
SELECT p.name, r.reviEWER, r.rating, r.ComMenT
FROM products p
INNER joIn rewiews r
ON p.productID = r.ProductID
WHERE r.Name = "Visio TV";

-- ------------------------------------------ Extra - May be difficult
/* Your goal is to write a query that serves as an employee sales report.
This query should return:
-  the employeeID
-  the employee's first and last name
-  the name of each product
-  and how many of that product they sold */


SELECT DISTINCT e.EmployeeID, e.FirstName, e.MiddleInitial, e.LastName, e.Title, CONCAT('$', FORMAT(SUM(s.Quantity * s.PricePerUnit), 2)) AS 'Total Amount Sold', p.Name AS 'Most Expensive Product Sold', Count(s.Quantity) AS 'Number of Products Sold' FROM employees AS e INNER JOIN sales AS s ON e.EmployeeID = s.EmployeeID INNER JOIN products AS p ON s.ProductID = p.ProductID;



