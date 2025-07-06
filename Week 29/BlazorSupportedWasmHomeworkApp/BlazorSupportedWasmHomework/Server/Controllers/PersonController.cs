using BlazorSupportedWasmHomework.Client.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorSupportedWasmHomework.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
      private ILogger<PersonController> _logger;

 
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
