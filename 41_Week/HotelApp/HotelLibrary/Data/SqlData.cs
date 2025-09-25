using HotelLibrary.Data;
using HotelLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLibrary.Data
{
    public class SqlData : ISqlData
    {
        private readonly ISQLDataAccess _db;
        private const string connectionStringName = "SqlDb";
        public SqlData(ISQLDataAccess db)
        {
            _db = db;

        }
        public List<RoomTypeModel> GetAvailableRooms(DateTime startDate, DateTime endDate)
        {
            string sql = "dbo.spRoomtypes_GetAvailableTypes";
            var output = _db.LoadData<RoomTypeModel, dynamic>(sql, new { StartDate = startDate, EndDate = endDate }, connectionStringName, true);
            return output;

        }

        public void BookGuest(string firstName, string lastName, DateTime startDate, DateTime endDate, int roomTypeId)
        {
            // get guest that wants to book 
            GuestModel guest = _db.LoadData<GuestModel, dynamic>("dbo.spGuests_Insert", new { FirstName = firstName, LastName = lastName }, connectionStringName, true).First();


            RoomTypeModel roomType = _db.LoadData<RoomTypeModel, dynamic>("select * from dbo.RoomTypes where Id = @Id", new { Id = roomTypeId }, connectionStringName, false).First();

            TimeSpan timeStaying = endDate.Date.Subtract(startDate.Date); // number of days(timespan)


            // get list of available room
            List<RoomModel> availableRooms = _db.LoadData<RoomModel, dynamic>("dbo.spRooms_GetAvailable", new { startDate, endDate, roomTypeId }, connectionStringName, true);

            // book the room
            _db.SaveData("dbo.spBookings_Insert", new { RoomId = availableRooms.First().Id, GuestId = guest.Id, StartDate = startDate, EndDate = endDate, TotalCost = timeStaying.Days * roomType.Price }, connectionStringName, true);

        }


        public List<BookingFullModel> SearchGuest(string lastName)
        {
            string sql = "dbo.spGuests_Search";
            var output = _db.LoadData<BookingFullModel, dynamic>(sql, new { LastName = lastName, StartDate = DateTime.Now.Date }, connectionStringName, true);
            return output;
        }

        public void CheckGuestIn(int bookingId)
        {
            string sql = "dbo.spBookings_CheckeIn";
            _db.SaveData(sql, new { Id = bookingId }, connectionStringName, true);
        }
    }
}
