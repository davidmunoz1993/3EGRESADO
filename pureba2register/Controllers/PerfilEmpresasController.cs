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
    [Authorize(Roles = "Empresa")]
    public class PerfilEmpresasController : Controller
    {
        private pureba2registerContext db = new pureba2registerContext();

        // GET: PerfilEmpresas
        public ActionResult Index()
        {
            return View(db.CrearPerfilEmpresas.ToList());
        }

        // GET: PerfilEmpresas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CrearPerfilEmpresa crearPerfilEmpresa = db.CrearPerfilEmpresas.Find(id);
            if (crearPerfilEmpresa == null)
            {
                return HttpNotFound();
            }
            return View(crearPerfilEmpresa);
        }


        // GET: PerfilEmpresas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PerfilEmpresas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CrearPerfilEmpresaID,NombreEmpresa,Nit,DireccionEmpresa,NumeroEgresado,DescripccionEmpresa")] CrearPerfilEmpresa crearPerfilEmpresa)
        {
            if (ModelState.IsValid)
            {
                db.CrearPerfilEmpresas.Add(crearPerfilEmpresa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(crearPerfilEmpresa);
        }

        // GET: PerfilEmpresas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CrearPerfilEmpresa crearPerfilEmpresa = db.CrearPerfilEmpresas.Find(id);
            if (crearPerfilEmpresa == null)
            {
                return HttpNotFound();
            }
            return View(crearPerfilEmpresa);
        }
        // POST: CrearPerfilEmpresas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CrearPerfilEmpresaID,NombreEmpresa,Nit,DireccionEmpresa,NumeroEgresado,DescripccionEmpresa")] CrearPerfilEmpresa crearPerfilEmpresa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(crearPerfilEmpresa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(crearPerfilEmpresa);
        }


        // GET: PerfilEmpresas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PerfilEmpresa perfilEmpresa = db.PerfilEmpresas.Find(id);
            if (perfilEmpresa == null)
            {
                return HttpNotFound();
            }
            return View(perfilEmpresa);
        }

        // POST: PerfilEmpresas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PerfilEmpresa perfilEmpresa = db.PerfilEmpresas.Find(id);
            db.PerfilEmpresas.Remove(perfilEmpresa);
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
