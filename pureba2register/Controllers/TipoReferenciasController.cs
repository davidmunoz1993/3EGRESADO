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
    public class TipoReferenciasController : Controller
    {
        private pureba2registerContext db = new pureba2registerContext();

        // GET: TipoReferencias
        public ActionResult Index()
        {
            return View(db.TipoReferencias.ToList());
        }

        // GET: TipoReferencias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoReferencia tipoReferencia = db.TipoReferencias.Find(id);
            if (tipoReferencia == null)
            {
                return HttpNotFound();
            }
            return View(tipoReferencia);
        }

        // GET: TipoReferencias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoReferencias/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TipoReferenciaID,NombreTipoReferencia")] TipoReferencia tipoReferencia)
        {
            if (ModelState.IsValid)
            {
                db.TipoReferencias.Add(tipoReferencia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoReferencia);
        }

        // GET: TipoReferencias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoReferencia tipoReferencia = db.TipoReferencias.Find(id);
            if (tipoReferencia == null)
            {
                return HttpNotFound();
            }
            return View(tipoReferencia);
        }

        // POST: TipoReferencias/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TipoReferenciaID,NombreTipoReferencia")] TipoReferencia tipoReferencia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoReferencia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoReferencia);
        }

        // GET: TipoReferencias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoReferencia tipoReferencia = db.TipoReferencias.Find(id);
            if (tipoReferencia == null)
            {
                return HttpNotFound();
            }
            return View(tipoReferencia);
        }

        // POST: TipoReferencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoReferencia tipoReferencia = db.TipoReferencias.Find(id);
            db.TipoReferencias.Remove(tipoReferencia);
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
