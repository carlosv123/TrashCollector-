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
    public class infoesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: infoes
        public ActionResult Index()
        {
            var infoes = db.infoes.Include(i => i.Amountt);
            return View(infoes.ToList());
        }

        // GET: infoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            info info = db.infoes.Find(id);
            if (info == null)
            {
                return HttpNotFound();
            }
            return View(info);
        }

        // GET: infoes/Create
        public ActionResult Create()
        {
            ViewBag.Amountid = new SelectList(db.Amounts, "id", "id");
            return View();
        }

        // POST: infoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,firstname,lastname,Amountid")] info info)
        {
            if (ModelState.IsValid)
            {
                db.infoes.Add(info);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Amountid = new SelectList(db.Amounts, "id", "id", info.Amountid);
            return View(info);
        }

        // GET: infoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            info info = db.infoes.Find(id);
            if (info == null)
            {
                return HttpNotFound();
            }
            ViewBag.Amountid = new SelectList(db.Amounts, "id", "id", info.Amountid);
            return View(info);
        }

        // POST: infoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,firstname,lastname,Amountid")] info info)
        {
            if (ModelState.IsValid)
            {
                db.Entry(info).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Amountid = new SelectList(db.Amounts, "id", "id", info.Amountid);
            return View(info);
        }

        // GET: infoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            info info = db.infoes.Find(id);
            if (info == null)
            {
                return HttpNotFound();
            }
            return View(info);
        }

        // POST: infoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            info info = db.infoes.Find(id);
            db.infoes.Remove(info);
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
