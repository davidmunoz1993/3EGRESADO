using pureba2register.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace pureba2register.Controllers
{
    public class PublicacionAdminsController : Controller
    {
        private pureba2registerContext db = new pureba2registerContext();

        // GET: PublicacionAdmins
        public ActionResult Index()
        {
            return View(db.PublicacionAdmins.ToList());
        }

        // GET: PublicacionAdmins/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PublicacionAdmin publicacionAdmin = db.PublicacionAdmins.Find(id);
            if (publicacionAdmin == null)
            {
                return HttpNotFound();
            }
            return View(publicacionAdmin);
        }

        // GET: PublicacionAdmins/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PublicacionAdmins/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PublicacionAdminID,FechaInicio,FechaFinalizacion,Asunto,Informacion,EstadoPublicacion")] PublicacionAdmin publicacionAdmin)
        {
            if (ModelState.IsValid)
            {
                db.PublicacionAdmins.Add(publicacionAdmin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(publicacionAdmin);
        }

        // GET: PublicacionAdmins/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PublicacionAdmin publicacionAdmin = db.PublicacionAdmins.Find(id);
            if (publicacionAdmin == null)
            {
                return HttpNotFound();
            }
            return View(publicacionAdmin);
        }

        // POST: PublicacionAdmins/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PublicacionAdminID,FechaInicio,FechaFinalizacion,Asunto,Informacion,EstadoPublicacion")] PublicacionAdmin publicacionAdmin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(publicacionAdmin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(publicacionAdmin);
        }

        // GET: PublicacionAdmins/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PublicacionAdmin publicacionAdmin = db.PublicacionAdmins.Find(id);
            if (publicacionAdmin == null)
            {
                return HttpNotFound();
            }
            return View(publicacionAdmin);
        }

        // POST: PublicacionAdmins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PublicacionAdmin publicacionAdmin = db.PublicacionAdmins.Find(id);
            db.PublicacionAdmins.Remove(publicacionAdmin);
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
