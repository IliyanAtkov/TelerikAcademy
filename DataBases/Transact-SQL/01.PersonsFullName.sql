USE TSQLHomeworkDatabase
GO
CREATE PROC usp_PersonsFullName
AS
  SELECT FirstName + ' ' +  LastName as [Full Name] 
  FROM Persons
GO

EXEC usp_Select_All_Persons