using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollector.Models;
using static System.Net.Mime.MediaTypeNames;

namespace TrashCollector.Controllers
{
    public class TrashEsController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: TrashEs
        public ActionResult Index()
        {
            //var customers = db.TrashC;
            //return View(customers.ToList());
            var currentEmployee = User.Identity.GetUserId();
            var TrashEm = db.TrashE.Where(s => s.ApplicationUserId == currentEmployee).SingleOrDefault();
            return View(TrashEm);
        }

        

        // GET: TrashEs/Details/5
        public ActionResult Details(int Id = 0)
        {
            var trashEmploy = db.TrashE;
            return View(trashEmploy.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "Name, CustomerBill, TrashPickUpStatus")] TrashE employee)
        {

            string currentUserId = User.Identity.GetUserId();
            employee.ApplicationUserId = currentUserId;

            //customer.ExtraPickUp = null;
            //DateTime yearOne = new DateTime(1, 1, 1);
            db.TrashE.Add(employee);
            db.SaveChanges();
            return RedirectToAction("Index");        }

        // GET: TrashEs/Edit/5
        public ActionResult Edit(int id)
        {
            TrashE employee = db.TrashE.Find(id);
            return View(employee);
        }

        // POST: TrashEs/Edit/5
        [HttpPost]
        public ActionResult Edit(TrashE employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: TrashEs/Delete/5
        public ActionResult Delete(int id)
        {
            TrashE employee = db.TrashE.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

  
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TrashE employee = db.TrashE.Find(id);
            db.TrashE.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
