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
    public class requestformsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: requestforms
        public ActionResult Index()
        {
            return View(db.requestforms.ToList());
        }

        // GET: requestforms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            requestform requestform = db.requestforms.Find(id);
            if (requestform == null)
            {
                return HttpNotFound();
            }
            return View(requestform);
        }

        // GET: requestforms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: requestforms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,firstName,lastName,nopickupstart,nopickupend")] requestform requestform)
        {
            if (ModelState.IsValid)
            {
                db.requestforms.Add(requestform);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(requestform);
        }

        // GET: requestforms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            requestform requestform = db.requestforms.Find(id);
            if (requestform == null)
            {
                return HttpNotFound();
            }
            return View(requestform);
        }

        // POST: requestforms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,firstName,lastName,nopickupstart,nopickupend")] requestform requestform)
        {
            if (ModelState.IsValid)
            {
                db.Entry(requestform).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(requestform);
        }

        // GET: requestforms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            requestform requestform = db.requestforms.Find(id);
            if (requestform == null)
            {
                return HttpNotFound();
            }
            return View(requestform);
        }

        // POST: requestforms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            requestform requestform = db.requestforms.Find(id);
            db.requestforms.Remove(requestform);
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
