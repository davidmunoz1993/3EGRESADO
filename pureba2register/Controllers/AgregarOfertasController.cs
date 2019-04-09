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
{   [Authorize(Roles ="Empresa")]
    public class AgregarOfertasController : Controller
    {
        private pureba2registerContext db = new pureba2registerContext();

        // GET: AgregarOfertas
        public ActionResult Index()
        {
            return View(db.AgregarOfertas.ToList());
        }

        // GET: AgregarOfertas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgregarOferta agregarOferta = db.AgregarOfertas.Find(id);
            if (agregarOferta == null)
            {
                return HttpNotFound();
            }
            return View(agregarOferta);
        }

        // GET: AgregarOfertas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AgregarOfertas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AgregarOfertaID,FechaInicio,FechaFinal,Asunto,PerfilRequerido,Descripcion")] AgregarOferta agregarOferta)
        {
            if (ModelState.IsValid)
            {
                db.AgregarOfertas.Add(agregarOferta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(agregarOferta);
        }

        // GET: AgregarOfertas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgregarOferta agregarOferta = db.AgregarOfertas.Find(id);
            if (agregarOferta == null)
            {
                return HttpNotFound();
            }
            return View(agregarOferta);
        }

        // POST: AgregarOfertas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AgregarOfertaID,FechaInicio,FechaFinal,Asunto,PerfilRequerido,Descripcion")] AgregarOferta agregarOferta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(agregarOferta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(agregarOferta);
        }

        // GET: AgregarOfertas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgregarOferta agregarOferta = db.AgregarOfertas.Find(id);
            if (agregarOferta == null)
            {
                return HttpNotFound();
            }
            return View(agregarOferta);
        }

        // POST: AgregarOfertas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AgregarOferta agregarOferta = db.AgregarOfertas.Find(id);
            db.AgregarOfertas.Remove(agregarOferta);
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
