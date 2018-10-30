﻿using Microsoft.AspNet.Identity;
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
        // GET: TrashCs
        public ActionResult Index()
        {
            return View();
        }

        // GET: TrashCs/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TrashCs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TrashCs/Create
        [HttpPost]
        public ActionResult Create(TrashC customer)
        {
            try
            {
                // get the ID of the currently logged in ApplicationUser
                string currentUserId = User.Identity.GetUserId();
                customer.ApplicationUserId = currentUserId;

                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TrashCs/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TrashCs/Edit/5
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

        // GET: TrashCs/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TrashCs/Delete/5
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
