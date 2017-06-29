using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HebbraCo_Lib;

namespace ICATask1.Controllers
{
    public class BusinessUnitController : Controller
    {
        private HebbraCo_Lib.HebbCo_Model db = new HebbraCo_Lib.HebbCo_Model();

        // GET: BusinessUnit
        public ActionResult Index()
        {
            var bu = db.BusinessUnits.Where(b => b.Active == true);
            return View(bu);
        }

        // GET: BusinessUnit/Details/5
        public ActionResult Details(int id)
        {
            BusinessUnit bu = db.BusinessUnits.Find(id);

            if (bu == null || bu.Active == false)
            {
                return HttpNotFound();
            }

            return View(bu);
        }

        // GET: BusinessUnit/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BusinessUnit/Create
        [HttpPost]
        public ActionResult Create(BusinessUnit bu)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.BusinessUnits.Add(bu);
                    bu.Active = true;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View(bu);
            }
        }

        // GET: BusinessUnit/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            BusinessUnit bu = db.BusinessUnits.Find(id);

            if (bu == null || bu.Active == false)
            {
                return HttpNotFound();
            }

            return View(bu);
        }

        // POST: BusinessUnit/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, BusinessUnit bu)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(bu).State = EntityState.Modified;
                    bu.Active = true;
                    db.SaveChanges();  
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View(bu);
            }
        }

        // GET: BusinessUnit/Delete/5
        public ActionResult Delete(int id)
        {
            BusinessUnit bu = db.BusinessUnits.Find(id);
            int staffCount = bu.Staffs.Where(s => s.Active == true).Count();
            if (staffCount > 0)
            {
                return RedirectToAction("Index");
            }
            if (bu == null || bu.Active == false)
            {
                return HttpNotFound();

            }
            return View(bu);
        }

        // POST: BusinessUnit/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, BusinessUnit bu)
        {
            try
            {
                bu = db.BusinessUnits.Find(id);
                if (bu.Active == true)
                {
                    bu.Active = false;
                }
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
