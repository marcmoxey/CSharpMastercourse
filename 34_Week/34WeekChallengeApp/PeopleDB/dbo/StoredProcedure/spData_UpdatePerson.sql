CREATE PROCEDURE [dbo].[spData_UpdatePerson]
	@Id int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50)
AS
BEGIN
	UPDATE [dbo].[People]
		SET FirstName = @FirstName, LastName = @LastName
		WHERE Id = @Id;
END
