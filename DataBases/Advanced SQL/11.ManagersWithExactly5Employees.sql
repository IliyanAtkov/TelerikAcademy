SELECT m.FirstName, m.LastName
FROM Employees m
	JOIN Employees e
		ON m.EmployeeID = e.ManagerID
GROUP BY m.FirstName, m.LastName
HAVING COUNT(e.EmployeeId) = 5