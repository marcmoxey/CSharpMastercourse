using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCDataEntry.Models;

namespace MVCDataEntry.Controllers
{
    public class PersonController : Controller
    {
        // GET: PersonController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PersonController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PersonModel person)
        {
            if (ModelState.IsValid == false)
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
