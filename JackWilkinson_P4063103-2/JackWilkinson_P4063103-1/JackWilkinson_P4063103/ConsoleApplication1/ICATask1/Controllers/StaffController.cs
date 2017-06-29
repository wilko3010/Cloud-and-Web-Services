using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HebbraCo_Lib;

namespace ICATask1.Controllers
{
    public class StaffController : Controller
    {
        private HebbCo_Model db = new HebbCo_Model();

        // GET: Staff
        public ActionResult Index()
        {
            var staff = db.Staffs.Where(s => s.Active == true);
            return View(staff);
        }

        // GET: Staff/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staff staff = db.Staffs.Find(id);
            if (staff == null)
            {
                return HttpNotFound();
            }
            return View(staff);
        }

        // GET: Staff/Create
        public ActionResult Create()
        {
            var items = db.BusinessUnits.Where(bu => bu.Active == true);
            ViewBag.businessUnitID = new SelectList(items, "businessUnitID", "title");
            return View();
        }

        // POST: Staff/Create
        [HttpPost]
        public ActionResult Create(Staff st)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    db.Staffs.Add(st);
                    st.Active = true;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View(st);
            }
        }

        // GET: Staff/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Staff staff = db.Staffs.Find(id);
            if (staff == null || staff.Active == false)
            {
                return HttpNotFound();
            }
            ViewBag.businessUnitId = new SelectList(db.BusinessUnits, "businessUnitId", "businessUnitCode",
                staff.businessUnitId);
            return View(staff);
        }

        // POST: Staff/Edit/5
        [HttpPost]
        public ActionResult Edit(
            [Bind(
                Include =
                    "staffId,businessUnitId,staffCode,firstName,middleName,lastName,dob,startDate,profile,emailAddress,Active"
                )] Staff staff)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    db.Entry(staff).State = EntityState.Modified;
                    staff.Active = true;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.businessUnitId = new SelectList(db.BusinessUnits, "businessUnitId", "businessUnitCode",
                    staff.businessUnitId);
                return View(staff);
            }
        }

        // GET: Staff/Delete/5
        public ActionResult Delete(int id)
        {
            Staff staff = db.Staffs.Find(id);
            if (staff == null || staff.Active == false)
            {
                return HttpNotFound();
            }
            return View(staff);
        }

        // POST: Staff/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult Delete(int id, Staff staff)
        {
            try
            {
                staff = db.Staffs.Find(id);
                if (staff.Active == true)
                {
                    staff.Active = false;
                }
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult StaffBBU(int id)
        {
            var staffsBbu = db.Staffs.Where(s => s.Active == true).Where(s => s.businessUnitId == id);
            int sCount = staffsBbu.Count();
            if (sCount < 0)
            {
                return View("Index");
            }
            return View(staffsBbu);
        }
            
        }

}

