using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using pureba2register.Models;

namespace pureba2register.Controllers
{
    public class RangoSalarialsController : Controller
    {
        private pureba2registerContext db = new pureba2registerContext();

        // GET: RangoSalarials
        public ActionResult Index()
        {
            return View(db.RangoSalarials.ToList());
        }

        // GET: RangoSalarials/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RangoSalarial rangoSalarial = db.RangoSalarials.Find(id);
            if (rangoSalarial == null)
            {
                return HttpNotFound();
            }
            return View(rangoSalarial);
        }

        // GET: RangoSalarials/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RangoSalarials/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RangoSalarialID,CantidadRangoSalarial")] RangoSalarial rangoSalarial)
        {
            if (ModelState.IsValid)
            {
                db.RangoSalarials.Add(rangoSalarial);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rangoSalarial);
        }

        // GET: RangoSalarials/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RangoSalarial rangoSalarial = db.RangoSalarials.Find(id);
            if (rangoSalarial == null)
            {
                return HttpNotFound();
            }
            return View(rangoSalarial);
        }

        // POST: RangoSalarials/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RangoSalarialID,CantidadRangoSalarial")] RangoSalarial rangoSalarial)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rangoSalarial).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rangoSalarial);
        }

        // GET: RangoSalarials/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RangoSalarial rangoSalarial = db.RangoSalarials.Find(id);
            if (rangoSalarial == null)
            {
                return HttpNotFound();
            }
            return View(rangoSalarial);
        }

        // POST: RangoSalarials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RangoSalarial rangoSalarial = db.RangoSalarials.Find(id);
            db.RangoSalarials.Remove(rangoSalarial);
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
