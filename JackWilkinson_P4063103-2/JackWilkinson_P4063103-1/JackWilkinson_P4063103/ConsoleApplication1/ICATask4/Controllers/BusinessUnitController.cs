using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ICATask4.Controllers
{
    public class BusinessUnitController : Controller
    {
        // GET: BusinessUnit
     
              public ActionResult Index()
   {
                  //this method will connect the web api business unit to all of the business units
                  //and it will then return the business units in a formatted view
     HttpClient buClient = new HttpClient();
     buClient.BaseAddress = new System.Uri("http://localhost:33103/");
     buClient.DefaultRequestHeaders.Accept.ParseAdd("application/json");
     HttpResponseMessage response = buClient.GetAsync("api/BusinessUnitT2").Result;
     if (response.IsSuccessStatusCode)
        {
            var bu = response.Content.ReadAsAsync<IEnumerable<ICATask4.Models.BDTO>>().Result;
            return View(bu);
         }
            return View();           

        }

        // GET: BusinessUnit/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BusinessUnit/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BusinessUnit/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BusinessUnit/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BusinessUnit/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BusinessUnit/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BusinessUnit/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
