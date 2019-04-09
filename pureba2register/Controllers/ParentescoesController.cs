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
    public class ParentescoesController : Controller
    {
        private pureba2registerContext db = new pureba2registerContext();

        // GET: Parentescoes
        public ActionResult Index()
        {
            return View(db.Parentescoes.ToList());
        }

        // GET: Parentescoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Parentesco parentesco = db.Parentescoes.Find(id);
            if (parentesco == null)
            {
                return HttpNotFound();
            }
            return View(parentesco);
        }

        // GET: Parentescoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Parentescoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ParentescoID,TipoParentesco")] Parentesco parentesco)
        {
            if (ModelState.IsValid)
            {
                db.Parentescoes.Add(parentesco);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(parentesco);
        }

        // GET: Parentescoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Parentesco parentesco = db.Parentescoes.Find(id);
            if (parentesco == null)
            {
                return HttpNotFound();
            }
            return View(parentesco);
        }

        // POST: Parentescoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ParentescoID,TipoParentesco")] Parentesco parentesco)
        {
            if (ModelState.IsValid)
            {
                db.Entry(parentesco).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(parentesco);
        }

        // GET: Parentescoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Parentesco parentesco = db.Parentescoes.Find(id);
            if (parentesco == null)
            {
                return HttpNotFound();
            }
            return View(parentesco);
        }

        // POST: Parentescoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Parentesco parentesco = db.Parentescoes.Find(id);
            db.Parentescoes.Remove(parentesco);
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
