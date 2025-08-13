CREATE PROCEDURE [dbo].[spData_RemovePerson]
	@Id int

AS
BEGIN
	DELETE 
	FROM [dbo].[People]
	WHERE Id = @Id
END

