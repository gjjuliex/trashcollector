using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrashCollector.Controllers
{
    public class TrashEsController : Controller
    {
        // GET: TrashEs
        public ActionResult Index()
        {
            return View();
        }

        // GET: TrashEs/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TrashEs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TrashEs/Create
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
