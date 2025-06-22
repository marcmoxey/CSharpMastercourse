using ApiMiniProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiMiniProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : Controller
    {
        private readonly ILogger<AddressController> _logger;

        public IActionResult Index()
        {
            return View();
        }

        public AddressController(ILogger<AddressController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public void Post([FromBody] AddressModel address)
        {
            _logger.LogInformation("The address is {Address} ", address);
        }
    }
}
