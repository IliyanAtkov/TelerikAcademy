SELECT Count(e.FirstName) as NumberOfEmployees, d.Name
FROM Departments d
	JOIN Employees e
		ON e.DepartmentID = d.DepartmentID 
WHERE d.Name = 'Sales'
GROUP BY d.Name