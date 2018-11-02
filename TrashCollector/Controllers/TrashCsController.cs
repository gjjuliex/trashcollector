using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class TrashCsController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: TrashCs
        public ActionResult Index(TrashE e)
        {
            //var customer = db.TrashC.Where(c => c.Days == e.Days ).ToList();
            //return View(customer);

            var customers = db.TrashC.ToList();
            return View(customers);

        }

        public ActionResult Index2()
        {
            var empNumber = User.Identity.GetUserId();
            var emp = db.TrashE.Where(e => e.ApplicationUserId == empNumber).SingleOrDefault();
            var zipCode = db.TrashC.Where(z => z.Zipcode == emp.ZipCode).ToList();
            return View(zipCode);
         

        }

        public ActionResult Details()
        {
            var currentCustomer = User.Identity.GetUserId();
            var TrashCust = db.TrashC.Where(s => s.ApplicationUserId == currentCustomer).SingleOrDefault();
            
            return View(TrashCust);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create([Bind(Include = "FirstName, LastName, Address, City, State, Zipcode, Days, StartDate, EndDate, ExtraPickIp, Bill")] TrashC customer)
        {
            string currentUserId = User.Identity.GetUserId();
            customer.ApplicationUserId = currentUserId;
            db.TrashC.Add(customer);
            db.SaveChanges();
            return RedirectToAction("Details");
        }
        public ActionResult Edit (int id = 0)
        {
            TrashC customer = db.TrashC.Find(id);
            return View(customer);
        }

        [HttpPost]
        public ActionResult Edit (TrashC customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }
  
        public ActionResult Delete(int id)
        {
            TrashC customer = db.TrashC.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TrashC customer = db.TrashC.Find(id);
            db.TrashC.Remove(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
