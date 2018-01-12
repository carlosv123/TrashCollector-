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
    public class AmountsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Amounts
        public ActionResult Index()
        {
            return View(db.Amounts.ToList());
        }

        // GET: Amounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Amount amount = db.Amounts.Find(id);
            if (amount == null)
            {
                return HttpNotFound();
            }
            return View(amount);
        }

        // GET: Amounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Amounts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,paymentAmount")] Amount amount)
        {
            if (ModelState.IsValid)
            {
                db.Amounts.Add(amount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(amount);
        }

        // GET: Amounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Amount amount = db.Amounts.Find(id);
            if (amount == null)
            {
                return HttpNotFound();
            }
            return View(amount);
        }

        // POST: Amounts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,paymentAmount")] Amount amount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(amount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(amount);
        }

        // GET: Amounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Amount amount = db.Amounts.Find(id);
            if (amount == null)
            {
                return HttpNotFound();
            }
            return View(amount);
        }

        // POST: Amounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Amount amount = db.Amounts.Find(id);
            db.Amounts.Remove(amount);
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
