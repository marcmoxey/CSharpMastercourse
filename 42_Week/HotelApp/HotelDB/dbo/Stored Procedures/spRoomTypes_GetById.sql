CREATE PROCEDURE [dbo].[spRoomTypes_GetById]
	@Id int
AS
begin 
	set nocount on;

	SELECT [Id], [Title], [Description], [Price] 
	from dbo.RoomTypes 
	where Id = @Id

end