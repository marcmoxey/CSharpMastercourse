CREATE PROCEDURE [dbo].[spGuests_Insert]
	@FirstName nvarchar(50),
	@LastName nvarchar(50)
AS
begin 
	set nocount on;

	if not exists (select 1 from dbo.Guests where FirstName = @FirstName and LastName = @LastName)
	begin
		insert into Guests(FirstName, LastName)
		values (@FirstName,@LastName)
	end 
		
		select [Id], [FirstName], [LastName]
		from dbo.Guests
		where FirstName = @FirstName and LastName = @LastName
end