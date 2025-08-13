using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCMiniProject.Models;

namespace MVCMiniProject.Controllers
{
    public class Addresscontroller : Controller
    {
        // GET: Addresscontroller
        public ActionResult Index()
        {
            return View();
        }

        // GET: Addresscontroller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Addresscontroller/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AddressModel address)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = $" {address.StreetAddress} {address.City} {address.State} {address.ZipCode} has been added";
            }

            return View(address);
        }



        // GET: Addresscontroller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Addresscontroller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Addresscontroller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Addresscontroller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
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
