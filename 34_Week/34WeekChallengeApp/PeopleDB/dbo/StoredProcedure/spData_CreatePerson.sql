CREATE PROCEDURE [dbo].[spData_CreatePerson]
	@FirstName nvarchar(50),
	@LastName nvarchar(50)
AS
BEGIN
	insert into [dbo].[People] (FirstName, LastName)
	VALUES (@FirstName, @LastName);
END