using ApiMiniProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiMiniProject.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : Controller
    {
        private ILogger<PersonController> _logger;

        public IActionResult Index()
        {
            return View();
        }
        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public void Post([FromBody] PersonModel person)
        {
            _logger.LogInformation("Our create person was {Person}", person);
        }
    }
}
