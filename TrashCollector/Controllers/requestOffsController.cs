﻿using System;
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
    public class requestOffsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: requestOffs
        public ActionResult Index()
        {
            return View(db.requestOffs.ToList());
        }

        // GET: requestOffs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            requestOff requestOff = db.requestOffs.Find(id);
            if (requestOff == null)
            {
                return HttpNotFound();
            }
            return View(requestOff);
        }

        // GET: requestOffs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: requestOffs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,firstName,lastName,requestStart,requestEnd")] requestOff requestOff)
        {
            if (ModelState.IsValid)
            {
                db.requestOffs.Add(requestOff);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(requestOff);
        }

        // GET: requestOffs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            requestOff requestOff = db.requestOffs.Find(id);
            if (requestOff == null)
            {
                return HttpNotFound();
            }
            return View(requestOff);
        }

        // POST: requestOffs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,firstName,lastName,requestStart,requestEnd")] requestOff requestOff)
        {
            if (ModelState.IsValid)
            {
                db.Entry(requestOff).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(requestOff);
        }

        // GET: requestOffs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            requestOff requestOff = db.requestOffs.Find(id);
            if (requestOff == null)
            {
                return HttpNotFound();
            }
            return View(requestOff);
        }

        // POST: requestOffs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            requestOff requestOff = db.requestOffs.Find(id);
            db.requestOffs.Remove(requestOff);
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
