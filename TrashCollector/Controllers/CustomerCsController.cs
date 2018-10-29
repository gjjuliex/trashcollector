using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class CustomerCsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CustomerCs
        public ActionResult Index()
        {
            return View(db.TrashC.ToList());
        }

        // GET: CustomerCs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrashC trashC = db.TrashC.Find(id);
            if (trashC == null)
            {
                return HttpNotFound();
            }
            return View(trashC);
        }

        // GET: CustomerCs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerCs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Zipcode,Date,Days,Bill,StartDate,EndDate,Address")] TrashC trashC)
        {
            if (ModelState.IsValid)
            {
                db.TrashC.Add(trashC);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(trashC);
        }

        // GET: CustomerCs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrashC trashC = db.TrashC.Find(id);
            if (trashC == null)
            {
                return HttpNotFound();
            }
            return View(trashC);
        }

        // POST: CustomerCs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Zipcode,Date,Days,Bill,StartDate,EndDate,Address")] TrashC trashC)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trashC).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trashC);
        }

        // GET: CustomerCs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrashC trashC = db.TrashC.Find(id);
            if (trashC == null)
            {
                return HttpNotFound();
            }
            return View(trashC);
        }

        // POST: CustomerCs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TrashC trashC = db.TrashC.Find(id);
            db.TrashC.Remove(trashC);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
