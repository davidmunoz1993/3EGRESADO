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
    public class ReferenciasPersonalesController : Controller
    {
        private pureba2registerContext db = new pureba2registerContext();

        // GET: ReferenciasPersonales
        public ActionResult Index()
        {
            var referenciasPersonales = db.ReferenciasPersonales.Include(r => r.InformacionPersonal).Include(r => r.Parentesco).Include(r => r.TipoReferencia);
            return View(referenciasPersonales.ToList());
        }

        // GET: ReferenciasPersonales/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferenciasPersonales referenciasPersonales = db.ReferenciasPersonales.Find(id);
            if (referenciasPersonales == null)
            {
                return HttpNotFound();
            }
            return View(referenciasPersonales);
        }

        // GET: ReferenciasPersonales/Create
        public ActionResult Create()
        {
            ViewBag.InformacionPersonalID = new SelectList(db.InformacionPersonals, "InformacionPersonalID", "NombresEgresado");
            ViewBag.ParentescoID = new SelectList(db.Parentescoes, "ParentescoID", "TipoParentesco");
            ViewBag.TipoReferenciaID = new SelectList(db.TipoReferencias, "TipoReferenciaID", "NombreTipoReferencia");
            return View();
        }

        // POST: ReferenciasPersonales/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "referenciasPersonalesID,nombresReferencia,primerApellidoReferencia,segundoApellidoReferencia,cargoReferencia,telefonoFijoReferencia,extTelefonoReferencia,telefonoMovilReferencia,InformacionPersonalID,ParentescoID,TipoReferenciaID")] ReferenciasPersonales referenciasPersonales)
        {
            if (ModelState.IsValid)
            {
                db.ReferenciasPersonales.Add(referenciasPersonales);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.InformacionPersonalID = new SelectList(db.InformacionPersonals, "InformacionPersonalID", "NombresEgresado", referenciasPersonales.InformacionPersonalID);
            ViewBag.ParentescoID = new SelectList(db.Parentescoes, "ParentescoID", "TipoParentesco", referenciasPersonales.ParentescoID);
            ViewBag.TipoReferenciaID = new SelectList(db.TipoReferencias, "TipoReferenciaID", "NombreTipoReferencia", referenciasPersonales.TipoReferenciaID);
            return View(referenciasPersonales);
        }

        // GET: ReferenciasPersonales/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferenciasPersonales referenciasPersonales = db.ReferenciasPersonales.Find(id);
            if (referenciasPersonales == null)
            {
                return HttpNotFound();
            }
            ViewBag.InformacionPersonalID = new SelectList(db.InformacionPersonals, "InformacionPersonalID", "NombresEgresado", referenciasPersonales.InformacionPersonalID);
            ViewBag.ParentescoID = new SelectList(db.Parentescoes, "ParentescoID", "TipoParentesco", referenciasPersonales.ParentescoID);
            ViewBag.TipoReferenciaID = new SelectList(db.TipoReferencias, "TipoReferenciaID", "NombreTipoReferencia", referenciasPersonales.TipoReferenciaID);
            return View(referenciasPersonales);
        }

        // POST: ReferenciasPersonales/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "referenciasPersonalesID,nombresReferencia,primerApellidoReferencia,segundoApellidoReferencia,cargoReferencia,telefonoFijoReferencia,extTelefonoReferencia,telefonoMovilReferencia,InformacionPersonalID,ParentescoID,TipoReferenciaID")] ReferenciasPersonales referenciasPersonales)
        {
            if (ModelState.IsValid)
            {
                db.Entry(referenciasPersonales).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.InformacionPersonalID = new SelectList(db.InformacionPersonals, "InformacionPersonalID", "NombresEgresado", referenciasPersonales.InformacionPersonalID);
            ViewBag.ParentescoID = new SelectList(db.Parentescoes, "ParentescoID", "TipoParentesco", referenciasPersonales.ParentescoID);
            ViewBag.TipoReferenciaID = new SelectList(db.TipoReferencias, "TipoReferenciaID", "NombreTipoReferencia", referenciasPersonales.TipoReferenciaID);
            return View(referenciasPersonales);
        }

        // GET: ReferenciasPersonales/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferenciasPersonales referenciasPersonales = db.ReferenciasPersonales.Find(id);
            if (referenciasPersonales == null)
            {
                return HttpNotFound();
            }
            return View(referenciasPersonales);
        }

        // POST: ReferenciasPersonales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ReferenciasPersonales referenciasPersonales = db.ReferenciasPersonales.Find(id);
            db.ReferenciasPersonales.Remove(referenciasPersonales);
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
