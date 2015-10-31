SELECT AVG(e.Salary) as AverageSalary, e.DepartmentID
FROM Employees e
	JOIN Departments d
		ON d.DepartmentID = e.DepartmentID
GROUP BY e.DepartmentID