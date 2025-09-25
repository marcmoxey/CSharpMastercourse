CREATE PROCEDURE [dbo].[spBookings_Search]
	@LastName nvarchar(50),
	@startDate date


AS
begin 
	set nocount on; 

	select  b.Id, b.RoomId, b.GuestId, b.StartDate, b.EndDate, 
		b.CheckedIn, b.TotalCost, g.FirstName, g.LastName, r.RoomNumber, r.RoomTypeId, rt.Title, rt.[Description],
		rt.Price
	from Guests g
	inner join Bookings  b on g.Id = b.GuestId
	inner join Rooms r on b.RoomId = r.Id
	inner join RoomTypes rt on r.RoomTypeId = rt.Id
	where g.LastName = @LastName and b.StartDate = @startDate
end
