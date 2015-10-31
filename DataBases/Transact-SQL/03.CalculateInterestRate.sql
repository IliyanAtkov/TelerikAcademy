USE TSQLHomeworkDatabase
GO
CREATE FUNCTION usf_CalculateInterestRate (@sum FLOAT, @interestRate FLOAT, @numberOfMonths INT)
RETURNS FLOAT
AS
BEGIN
	DECLARE @newCalculatedSum FLOAT
	SET @newCalculatedSum = @sum + @sum * @interestRate * @numberOfMonths
	RETURN @newCalculatedSum
END
GO

SELECT dbo.usf_CalculateInterestRate(300, 0.2, 5)