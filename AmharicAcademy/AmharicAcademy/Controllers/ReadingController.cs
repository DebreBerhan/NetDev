using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AmharicAcademy.Models;

namespace AmharicAcademy.Controllers
{
    public class ReadingController : Controller
    {
        private ReadningContext db = new ReadningContext();

        // GET: AmharicReadings
        public ActionResult Index()
        {
            return View(db.AmReadingContext.ToList());
        }

        // GET: AmharicReadings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AmharicReading amharicReading = db.AmReadingContext.Find(id);
            if (amharicReading == null)
            {
                return HttpNotFound();
            }
            return View(amharicReading);
        }

        // GET: AmharicReadings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AmharicReadings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,readingTitle,AmharicReadingString,EnglishReadingString")] AmharicReading amharicReading)
        {
            if (ModelState.IsValid)
            {
                db.AmReadingContext.Add(amharicReading);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(amharicReading);
        }

        // GET: AmharicReadings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AmharicReading amharicReading = db.AmReadingContext.Find(id);
            if (amharicReading == null)
            {
                return HttpNotFound();
            }
            return View(amharicReading);
        }

        // POST: AmharicReadings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,readingTitle,AmharicReadingString,EnglishReadingString")] AmharicReading amharicReading)
        {
            if (ModelState.IsValid)
            {
                db.Entry(amharicReading).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(amharicReading);
        }

        // GET: AmharicReadings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AmharicReading amharicReading = db.AmReadingContext.Find(id);
            if (amharicReading == null)
            {
                return HttpNotFound();
            }
            return View(amharicReading);
        }

        // POST: AmharicReadings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AmharicReading amharicReading = db.AmReadingContext.Find(id);
            db.AmReadingContext.Remove(amharicReading);
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
