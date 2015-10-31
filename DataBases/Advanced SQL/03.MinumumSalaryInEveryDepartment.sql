SELECT FirstName, LastName, Salary, DepartmentID
FROM Employees e
WHERE Salary =
  (SELECT MIN(Salary)
   FROM Employees d
   WHERE d.DepartmentID = e.DepartmentID)