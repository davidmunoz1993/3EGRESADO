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
    public class CarreraProfesionalsController : Controller
    {
        private pureba2registerContext db = new pureba2registerContext();

        // GET: CarreraProfesionals
        public ActionResult Index()
        {
            return View(db.CarreraProfesionals.ToList());
        }

        // GET: CarreraProfesionals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarreraProfesional carreraProfesional = db.CarreraProfesionals.Find(id);
            if (carreraProfesional == null)
            {
                return HttpNotFound();
            }
            return View(carreraProfesional);
        }

        // GET: CarreraProfesionals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarreraProfesionals/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CarreraProfesionalID,NombreCarrera,DescripcionCarrera")] CarreraProfesional carreraProfesional)
        {
            if (ModelState.IsValid)
            {
                db.CarreraProfesionals.Add(carreraProfesional);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(carreraProfesional);
        }

        // GET: CarreraProfesionals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarreraProfesional carreraProfesional = db.CarreraProfesionals.Find(id);
            if (carreraProfesional == null)
            {
                return HttpNotFound();
            }
            return View(carreraProfesional);
        }

        // POST: CarreraProfesionals/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CarreraProfesionalID,NombreCarrera,DescripcionCarrera")] CarreraProfesional carreraProfesional)
        {
            if (ModelState.IsValid)
            {
                db.Entry(carreraProfesional).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(carreraProfesional);
        }

        // GET: CarreraProfesionals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarreraProfesional carreraProfesional = db.CarreraProfesionals.Find(id);
            if (carreraProfesional == null)
            {
                return HttpNotFound();
            }
            return View(carreraProfesional);
        }

        // POST: CarreraProfesionals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CarreraProfesional carreraProfesional = db.CarreraProfesionals.Find(id);
            db.CarreraProfesionals.Remove(carreraProfesional);
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
