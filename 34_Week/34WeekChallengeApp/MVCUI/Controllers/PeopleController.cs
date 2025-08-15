using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCUI.Controllers
{
    public class PeopleController : Controller
    {
        private readonly SqlCrud _sql;

        public PeopleController(SqlCrud sql)
        {
            _sql = sql;
        }
        // GET: PeopleController
        public ActionResult Index()
        {
            var people = _sql.GetAllPeople();
            return View(people);
        }

        // GET: People/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: PeopleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PersonModel person)
        {
            if(ModelState.IsValid)
            {
              _sql.CreatePerson(person);
              TempData["SuccessMessage"] = $"Person {person.FirstName} {person.LastName} created successfully!";

            }
         
            return View(person);
        }

        // gets id
        // GET: People/Edit/5
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var person = _sql.GetPersonById(id);
            if (person == null)
                return NotFound();

            return View(person);
        }

        // POST: People/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(PersonModel person)
        {
            if (ModelState.IsValid)
            {
                _sql.UpdatePerson(person);
                TempData["SuccessMessage"] = $"Person {person.FirstName} {person.LastName} updated successfully!";
                return RedirectToAction("Index");  // Redirect after successful POST (PRG pattern)
            }

            // If model invalid, show form again with validation errors
            return View(person);
        }

        // gets id
        // GET: People/Delete/5
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var person = _sql.GetPersonById(id);
            if (person == null)
                return NotFound();

            return View(person);
        }

        // POST: PeopleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(PersonModel person)
        {
          
                _sql.DeletePerson(person.Id);
                TempData["SuccessMessage"] = $"Person {person.FirstName} {person.LastName} deleted successfully!";
                return RedirectToAction("Index");
            
          
        }



    }
}
