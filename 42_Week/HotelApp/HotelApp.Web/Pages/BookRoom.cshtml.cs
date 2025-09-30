using HotelAppLibrary.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HotelApp.Web.Pages
{
    public class BookRoomModel : PageModel
    {
        public BookRoomModel(IDatabaseData db)
        {
            _db = db;
        }
        private readonly IDatabaseData _db;
        public void OnGet()
        {
        }


    }
}
