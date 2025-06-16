﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCAddressDataEntry.Models;
using System.Net;

namespace MVCAddressDataEntry.Controllers
{
    public class AddressController : Controller
    {
        // GET: AddressController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AddressController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AddressController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AddressController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AddressModel address)
        {
            if (ModelState.IsValid)
            {

                ViewBag.Message = $"{address.StreetAddress} {address.City} {address.State}, {address.ZipCode}";
            }


            return View(address);
        }

        // GET: AddressController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AddressController/Edit/5
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

       

        // GET: AddressController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AddressController/Delete/5
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
