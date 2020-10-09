using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyComputerRepairShop.DAL;
using MyComputerRepairShop.Models;

namespace MyComputerRepairShop.Controllers
{
    public class WorkerController : Controller
    {
        private MCRSContext db = new MCRSContext();

        // GET: Worker
        public ActionResult Index()
        {
            return View(db.workers.ToList());
        }

        // GET: Worker/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Worker worker = db.workers.Find(id);
            if (worker == null)
            {
                return HttpNotFound();
            }
            return View(worker);
        }

        // GET: Worker/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Worker/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,Infix,LastName,FullName,BirthDate,Wage,Department")] Worker worker)
        {
            if (ModelState.IsValid)
            {
                worker.FullName = worker.FirstName + " " + worker.Infix + " " + worker.LastName;
                db.workers.Add(worker);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(worker);
        }

        // GET: Worker/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Worker worker = db.workers.FirstOrDefault(w => w.Id == id);
            if (worker == null)
            {
                return HttpNotFound();
            }
            return View(worker);
        }

        // POST: Worker/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,Infix,LastName,FullName,BirthDate,Wage,Department")] Worker worker)
        {
            if (ModelState.IsValid)
            {
                worker.FullName = worker.FirstName + " " + worker.Infix + " " + worker.LastName;
                db.Entry(worker).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(worker);
        }

        // GET: Worker/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Worker worker = db.workers.Find(id);
            if (worker == null)
            {
                return HttpNotFound();
            }
            return View(worker);
        }

        // POST: Worker/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Worker worker = db.workers.Find(id);
            db.workers.Remove(worker);
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
