SELECT COUNT(*) as EmployeesCount, t.Name, e.DepartmentID
FROM Employees e
	JOIN Addresses a
		ON a.AddressID = e.AddressID
	JOIN Towns t
		ON t.TownID = a.TownID
GROUP BY t.Name, e.DepartmentID
ORDER BY DepartmentID