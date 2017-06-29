using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ICATask4.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        public ActionResult Index(String buCode)
        {
            //this method will connect the web api to all of the staff members and will return 
            //all of the staff members in a formatted view
            HttpClient sClient = new HttpClient();
            sClient.BaseAddress = new System.Uri("http://localhost:33103/");
            sClient.DefaultRequestHeaders.Accept.ParseAdd("application/json");
            HttpResponseMessage response = sClient.GetAsync("api/Staff/StaffBBU/" + buCode).Result;
            if (response.IsSuccessStatusCode)
            {
                var staff = response.Content.ReadAsAsync<IEnumerable<ICATask4.Models.SDTO>>().Result;
                return View(staff);
            }
            return View();
        }

        // GET: Staff/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Staff/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Staff/Create
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

        // GET: Staff/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Staff/Edit/5
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

        // GET: Staff/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Staff/Delete/5
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
