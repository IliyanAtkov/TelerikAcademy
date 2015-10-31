SELECT e.FirstName, e.LastName, m.LastName as ManagerLastName
FROM Employees e
	JOIN Employees m
		ON e.ManagerID = m.ManagerID