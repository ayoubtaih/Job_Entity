using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Job_Entity.Models;

namespace Job_Entity.Controllers
{
    public class DomainesController : Controller
    {
        private Job_Context db = new Job_Context();

        // GET: Domaines
        public ActionResult Index()
        {
            return View(db.Domaines.ToList());
        }

        // GET: Domaines/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Domaine domaine = db.Domaines.Find(id);
            if (domaine == null)
            {
                return HttpNotFound();
            }
            return View(domaine);
        }

        // GET: Domaines/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Domaines/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDdomaine,Libelle")] Domaine domaine)
        {
            if (ModelState.IsValid)
            {
                db.Domaines.Add(domaine);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(domaine);
        }

        // GET: Domaines/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Domaine domaine = db.Domaines.Find(id);
            if (domaine == null)
            {
                return HttpNotFound();
            }
            return View(domaine);
        }

        // POST: Domaines/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDdomaine,Libelle")] Domaine domaine)
        {
            if (ModelState.IsValid)
            {
                db.Entry(domaine).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(domaine);
        }

        // GET: Domaines/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Domaine domaine = db.Domaines.Find(id);
            if (domaine == null)
            {
                return HttpNotFound();
            }
            return View(domaine);
        }

        // POST: Domaines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Domaine domaine = db.Domaines.Find(id);
            db.Domaines.Remove(domaine);
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
