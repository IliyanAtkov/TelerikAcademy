SELECT e.FirstName, e.LastName, m.LastName as ManagerLastName, a.AddressText
FROM Employees e
	JOIN Employees m
		ON e.ManagerID = m.ManagerID
	JOIN Addresses a
		ON e.AddressID = a.AddressID