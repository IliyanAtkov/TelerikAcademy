SELECT Salary AS [Unique Salary]
FROM Employees
INTERSECT
SELECT Salary
FROM Employees
ORDER BY [Unique Salary]