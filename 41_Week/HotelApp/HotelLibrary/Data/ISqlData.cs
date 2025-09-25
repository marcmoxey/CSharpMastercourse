using HotelLibrary.Models;

namespace HotelLibrary.Data
{
    public interface ISqlData
    {
        void BookGuest(string firstName, string lastName, DateTime startDate, DateTime endDate, int roomTypeId);
        void CheckGuestIn(int bookingId);
        List<RoomTypeModel> GetAvailableRooms(DateTime startDate, DateTime endDate);
        List<BookingFullModel> SearchGuest(string lastName);
    }
}