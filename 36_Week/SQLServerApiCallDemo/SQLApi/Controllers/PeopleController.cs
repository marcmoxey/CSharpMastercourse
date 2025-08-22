using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SQLApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private SqlCrud db;
        private IConfiguration _config;

        public PeopleController(IConfiguration config)
        {
            _config = config;
            db = new SqlCrud(_config.GetConnectionString("Default"));
        }

        [HttpGet]
        public List<PersonModel> GetAll()
        {
            return db.GetAllPeople();
        }

        [HttpPost]
        public void CreatePerson(PersonModel person)
        {
            db.CreatePerson(person);
        }
    }
}
