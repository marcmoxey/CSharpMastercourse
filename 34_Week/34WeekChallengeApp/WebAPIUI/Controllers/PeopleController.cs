using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        SqlCrud sql = new SqlCrud(Tools.GetConnectionString());
        // GET: api/<PeopleController>
        [HttpGet]
        public IEnumerable<PersonModel> Get()
        {
            var person = sql.GetAllPeople();
            return person;
        }

        // GET api/<PeopleController>/5
        [HttpGet("{id}")]
        public PersonModel Get(int id)
        {
          var person = sql.GetPersonById(id);
            return person;
        }

        // POST api/<PeopleController>
        [HttpPost]
        public void Post([FromBody] PersonModel person)
        {
            sql.CreatePerson(person);
        }

        // PUT api/<PeopleController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] PersonModel person)
        {
            sql.UpdatePerson(person);
        }

        // DELETE api/<PeopleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            sql.DeletePerson(id);
        }
    }
}
