SELECT e.FirstName + ' ' + e.LastName AS FullName,
        ISNULL(m.FirstName + ' ' + m.LastName, '(no manager)') AS ManagerName
FROM Employees e
LEFT OUTER JOIN Employees m
ON e.ManagerID = m.EmployeeID