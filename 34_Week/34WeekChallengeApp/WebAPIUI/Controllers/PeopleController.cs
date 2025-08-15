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
        private readonly SqlCrud _sql;
        public PeopleController(SqlCrud sql)
        {
            _sql = sql;
        }
        // GET: api/<PeopleController>
        [HttpGet]
        public IEnumerable<PersonModel> Get()
        {
            var person = _sql.GetAllPeople();
            return person;
        }

        // GET api/<PeopleController>/5
        [HttpGet("{id}")]
        public PersonModel Get(int id)
        {
          var person = _sql.GetPersonById(id);
            return person;
        }

        // POST api/<PeopleController>
        [HttpPost]
        public void Post([FromBody] PersonModel person)
        {
            _sql.CreatePerson(person);
        }

        // PUT api/<PeopleController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] PersonModel person)
        {
            _sql.UpdatePerson(person);
        }

        // DELETE api/<PeopleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _sql.DeletePerson(id);
        }
    }
}
