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
    public class TipoEstudiosController : Controller
    {
        private pureba2registerContext db = new pureba2registerContext();

        // GET: TipoEstudios
        public ActionResult Index()
        {
            return View(db.TipoEstudios.ToList());
        }

        // GET: TipoEstudios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoEstudio tipoEstudio = db.TipoEstudios.Find(id);
            if (tipoEstudio == null)
            {
                return HttpNotFound();
            }
            return View(tipoEstudio);
        }

        // GET: TipoEstudios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoEstudios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TipoEstudioID,NombreTipoEstudio")] TipoEstudio tipoEstudio)
        {
            if (ModelState.IsValid)
            {
                db.TipoEstudios.Add(tipoEstudio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoEstudio);
        }

        // GET: TipoEstudios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoEstudio tipoEstudio = db.TipoEstudios.Find(id);
            if (tipoEstudio == null)
            {
                return HttpNotFound();
            }
            return View(tipoEstudio);
        }

        // POST: TipoEstudios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TipoEstudioID,NombreTipoEstudio")] TipoEstudio tipoEstudio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoEstudio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoEstudio);
        }

        // GET: TipoEstudios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoEstudio tipoEstudio = db.TipoEstudios.Find(id);
            if (tipoEstudio == null)
            {
                return HttpNotFound();
            }
            return View(tipoEstudio);
        }

        // POST: TipoEstudios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoEstudio tipoEstudio = db.TipoEstudios.Find(id);
            db.TipoEstudios.Remove(tipoEstudio);
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
