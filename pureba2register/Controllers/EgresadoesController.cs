using pureba2register.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace pureba2register.Controllers
{
    
    [Authorize(Roles ="Egresado")]
    public class EgresadoesController : Controller
    {
        private pureba2registerContext db = new pureba2registerContext();

        // GET: Egresadoes
        public ActionResult Index()
        {
            return View(db.Egresadoes.ToList());
        }

        // GET: Egresadoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Egresado egresado = db.Egresadoes.Find(id);
            if (egresado == null)
            {
                return HttpNotFound();
            }
            return View(egresado);
        }

        // GET: Egresadoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Egresadoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EgresadoID,Nombre,Apellido")] Egresado egresado)
        {
            if (ModelState.IsValid)
            {
                db.Egresadoes.Add(egresado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(egresado);
        }

        // GET: Egresadoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Egresado egresado = db.Egresadoes.Find(id);
            if (egresado == null)
            {
                return HttpNotFound();
            }
            return View(egresado);
        }

        // POST: Egresadoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EgresadoID,Nombre,Apellido")] Egresado egresado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(egresado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(egresado);
        }

        // GET: Egresadoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Egresado egresado = db.Egresadoes.Find(id);
            if (egresado == null)
            {
                return HttpNotFound();
            }
            return View(egresado);
        }

        // POST: Egresadoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Egresado egresado = db.Egresadoes.Find(id);
            db.Egresadoes.Remove(egresado);
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
