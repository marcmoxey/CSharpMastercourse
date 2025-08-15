using DataAccessLibrary.Models;
using DataAccessLibrary;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly SqlDataAccess _sql;

        public PeopleController(SqlDataAccess sql)
        {
            _sql = sql;
        }
        // GET: api/<PeopleController>
        [HttpGet]
        public async Task<List<PersonModel>> Index()
        {
            return await _sql.LoadPeople();
           
        }




    }
}
