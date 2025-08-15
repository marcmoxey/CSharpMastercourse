using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        private readonly SqlDataAccess _sql;
        public PeopleController(SqlDataAccess sql)
        {
            _sql = sql;
        }

        // GET: PeopleController
        public ActionResult Index()
        {
          List<PersonModel> people = _sql.LoadPeople();
            return View(people);
        }

      
    }
}
