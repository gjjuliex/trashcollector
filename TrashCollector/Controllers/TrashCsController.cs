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
        public ActionResult Index()
        {
            var TrashCust = db.TrashC;
            return View(TrashCust.ToList());
            
        }

        
        public ActionResult Details(int Id = 0)
        {
            TrashC customer = db.TrashC.Find(Id);
            return View(customer);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create([Bind(Include = "FirstName, LastName, Address, City, State, Zipcode, Days, StartDate, EndDate, ExtraPickIp, Bill")] TrashC customer)
        {
            string currentUserId = User.Identity.GetUserId();
            customer.ApplicationUserId = currentUserId;
            //customer.ExtraPickUp = null;
            //DateTime yearOne = new DateTime(1, 1, 1);
            db.TrashC.Add(customer);
            db.SaveChanges();
            return View("Details");
        }


        //[HttpPost]
        //public ActionResult Create(TrashC customer)
        //{
        //    try
        //    {
        //        // get the ID of the currently logged in ApplicationUser
        //        string currentUserId = User.Identity.GetUserId();
        //        customer.ApplicationUserId = currentUserId;

        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
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
