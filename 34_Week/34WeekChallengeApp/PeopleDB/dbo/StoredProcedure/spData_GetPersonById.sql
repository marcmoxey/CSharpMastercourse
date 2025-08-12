CREATE PROCEDURE [dbo].[spData_GetPersonById]
	 @Id int
AS
BEGIN
	SELECT 
		[Id]
		,[FirstName]
		,[LastName]
	FROM [dbo].[People]
	WHERE [Id] = @Id
END
