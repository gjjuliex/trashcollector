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
            var TrashE = db.TrashC;
            return View(TrashE);
        }

        // GET: TrashEs/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TrashEs/Create
        public ActionResult Create(TrashC employee)
        {
            string currentUserId = User.Identity.GetUserId();
            employee.ApplicationUserId = currentUserId;
            return View();
        }

        // POST: TrashEs/Create
        [HttpPost]
        public ActionResult Create()
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

        // GET: TrashEs/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TrashEs/Edit/5
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

        // GET: TrashEs/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TrashEs/Delete/5
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
