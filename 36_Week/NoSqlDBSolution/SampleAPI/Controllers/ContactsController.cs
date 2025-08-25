using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private  MongoDBDataAccess db;
        private  readonly string tableName = "Contacts";
        private readonly IConfiguration _config;

        public ContactsController(IConfiguration config)
        {
            _config = config;
            db = new MongoDBDataAccess("MongoContactsDB",_config.GetConnectionString("Default"));
            
        }

        // /api/contact/
        [HttpGet]
        public List<ContactModel> GetAll()
        {
            return db.LoadRecords<ContactModel>(tableName);
        }

        // /api/contact/
        [HttpPost]
        public void InsertRecord(ContactModel contact)     
        {
            db.UpsertRecord(tableName, contact.Id, contact);
        }
    }
}
