CREATE PROCEDURE [dbo].[spData_GetAllPeople]
AS
BEGIN
	SELECT 
		 [Id]
		,[FirstName]
		,[LastName]
	FROM [dbo].[People];
END

