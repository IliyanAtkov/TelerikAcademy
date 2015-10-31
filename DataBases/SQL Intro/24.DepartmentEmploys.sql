SELECT e.FirstName, e.LastName, d.Name
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
WHERE (e.HireDate >= 1995 OR e.HireDate <= 2005) AND
(d.Name IN ('Sales', 'Finance'))