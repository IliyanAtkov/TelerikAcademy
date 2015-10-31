SELECT e.FirstName, e.LastName, m.LastName as ManagerLastName
FROM Employees e
	RIGHT OUTER JOIN Employees m
		ON m.ManagerID = e.ManagerID

SELECT e.FirstName, e.LastName, m.LastName as ManagerLastName
FROM Employees e
	LEFT OUTER JOIN Employees m
		ON m.ManagerID = e.ManagerID