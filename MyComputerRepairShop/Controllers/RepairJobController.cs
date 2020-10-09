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
    public class RepairJobController : Controller
    {
        private MCRSContext db = new MCRSContext();

        // GET: RepairJobs
        public ActionResult Index()
        {
            return View(db.repairJobs.ToList());
        }

        // GET: RepairJobs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RepairJob repairJob = db.repairJobs.Find(id);
            if (repairJob == null)
            {
                return HttpNotFound();
            }
            return View(repairJob);
        }

        // GET: RepairJobs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RepairJobs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Startdate,Enddate,Detail,Status")] RepairJob repairJob)
        {
            if (ModelState.IsValid)
            {
                db.repairJobs.Add(repairJob);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(repairJob);
        }

        // GET: RepairJobs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RepairJob repairJob = db.repairJobs.Find(id);
            if (repairJob == null)
            {
                return HttpNotFound();
            }
            return View(repairJob);
        }

        // POST: RepairJobs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Startdate,Enddate,Detail,Status")] RepairJob repairJob)
        {
            if (ModelState.IsValid)
            {
                db.Entry(repairJob).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(repairJob);
        }

        // GET: RepairJobs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RepairJob repairJob = db.repairJobs.Find(id);
            if (repairJob == null)
            {
                return HttpNotFound();
            }
            return View(repairJob);
        }

        // POST: RepairJobs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RepairJob repairJob = db.repairJobs.Find(id);
            db.repairJobs.Remove(repairJob);
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
