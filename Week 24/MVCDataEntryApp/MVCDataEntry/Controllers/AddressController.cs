using Microsoft.AspNetCore.Mvc;
using MVCDataEntry.Models;


namespace MVCDataEntry.Controllers
{
    public class AddressController : Controller
    {

        private readonly ILogger<AddressController> _logger;

        public AddressController(ILogger<AddressController> logger)
        {
            _logger = logger;
        }




        // GET: AddressController
        public ActionResult Index()
        {
            return View();
        }



        // GET: AddressController/Create
        public ActionResult Create()
        {
            _logger.LogWarning("The user submit an invalid address upon create.");

            return View();
        }

        // POST: AddressController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AddressModel address)
        {
            if(ModelState.IsValid == false)
            {
                return View();
            }
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
