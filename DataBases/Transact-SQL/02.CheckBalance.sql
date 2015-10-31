USE TSQLHomeworkDatabase
GO
CREATE PROCEDURE usp_Check_Balance @balanceChecking INT
 AS
        SELECT FirstName + ' ' + LastName AS [FULL Name], SUM(a.Balance)
        FROM Persons p
        JOIN Accounts a
        ON p.PersonID = a.PersonID
		GROUP BY p.PersonID,FirstName + ' ' + LastName
        HAVING SUM(a.Balance) > @balanceChecking
GO
 
EXEC usp_Check_Balance 1000