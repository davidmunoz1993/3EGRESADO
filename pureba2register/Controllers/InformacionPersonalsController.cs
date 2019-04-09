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
    public class InformacionPersonalsController : Controller
    {
        private pureba2registerContext db = new pureba2registerContext();

        // GET: InformacionPersonals
        public ActionResult Index()
        {
            return View(db.InformacionPersonals.ToList());
        }

        // GET: InformacionPersonals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InformacionPersonal informacionPersonal = db.InformacionPersonals.Find(id);
            if (informacionPersonal == null)
            {
                return HttpNotFound();
            }
            return View(informacionPersonal);
        }

        // GET: InformacionPersonals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InformacionPersonals/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "InformacionPersonalID,NombresEgresado,PrimerApellidoEgresado,SegundoApellidoEgresado,FechaNacimientoEgresado,NumeroDocumentoEgresado,FechaExpedicionDocumento,SexoEgresado,correoEgresado,DireccionResidenciaEgresado,TelefonoMovilEgresado,TelefonoFijoEgresado,ExtencionTelefonoEgresado,NumeroActaGrado,FotoEgresado,EstadoEgresado")] InformacionPersonal informacionPersonal)
        {
            if (ModelState.IsValid)
            {
                db.InformacionPersonals.Add(informacionPersonal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(informacionPersonal);
        }

        // GET: InformacionPersonals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InformacionPersonal informacionPersonal = db.InformacionPersonals.Find(id);
            if (informacionPersonal == null)
            {
                return HttpNotFound();
            }
            return View(informacionPersonal);
        }

        // POST: InformacionPersonals/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "InformacionPersonalID,NombresEgresado,PrimerApellidoEgresado,SegundoApellidoEgresado,FechaNacimientoEgresado,NumeroDocumentoEgresado,FechaExpedicionDocumento,SexoEgresado,correoEgresado,DireccionResidenciaEgresado,TelefonoMovilEgresado,TelefonoFijoEgresado,ExtencionTelefonoEgresado,NumeroActaGrado,FotoEgresado,EstadoEgresado")] InformacionPersonal informacionPersonal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(informacionPersonal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(informacionPersonal);
        }

        // GET: InformacionPersonals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InformacionPersonal informacionPersonal = db.InformacionPersonals.Find(id);
            if (informacionPersonal == null)
            {
                return HttpNotFound();
            }
            return View(informacionPersonal);
        }

        // POST: InformacionPersonals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InformacionPersonal informacionPersonal = db.InformacionPersonals.Find(id);
            db.InformacionPersonals.Remove(informacionPersonal);
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
