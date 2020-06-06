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
    public class UtilisateursController : Controller
    {
        private Job_Context db = new Job_Context();

        // GET: Utilisateurs
        public ActionResult Index()
        {
            return View(db.Utilisateurs.ToList());
        }

        public ActionResult haha()
        {
            return View();
        }

        // GET: Utilisateurs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Utilisateur utilisateur = db.Utilisateurs.Find(id);
            if (utilisateur == null)
            {
                return HttpNotFound();
            }
            return View(utilisateur);
        }

        // GET: Utilisateurs/Create
        public ActionResult SignUp()
        {
            return View();
        }

        // POST: Utilisateurs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp([Bind(Include = "email,UserType,MotPasse")] Utilisateur utilisateur)
        {
            if (ModelState.IsValid)
            {



                utilisateur.DernierVisit = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                db.Utilisateurs.Add(utilisateur);
                db.SaveChanges();

                return RedirectToAction("Index");


                /*if (!db.Utilisateurs.Any(x => x.email.Equals(utilisateur.email)))
                {
                    utilisateur.DernierVisit = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    db.Utilisateurs.Add(utilisateur);
                    db.SaveChanges();

                    return RedirectToAction("Index");

                    /*if (utilisateur.UserType == "idvidual")
                    {
                        return RedirectToAction("Index");
                    }
                    if (utilisateur.UserType == "entreprise")
                    {
                        return RedirectToAction("atata");
                    }


                }
                else
                {
                    Response.Write(@"<script language='javascript'>alert('Message: \n" + "Email deja exist!" + " .');</script>");
                }*/

                
            }

            return View(utilisateur);
        }

        // GET: Utilisateurs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Utilisateur utilisateur = db.Utilisateurs.Find(id);
            if (utilisateur == null)
            {
                return HttpNotFound();
            }
            return View(utilisateur);
        }

        // POST: Utilisateurs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDUtilisateur,email,MotPasse,UserType,DernierVisit")] Utilisateur utilisateur)
        {
            if (ModelState.IsValid)
            {
                db.Entry(utilisateur).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(utilisateur);
        }

        // GET: Utilisateurs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Utilisateur utilisateur = db.Utilisateurs.Find(id);
            if (utilisateur == null)
            {
                return HttpNotFound();
            }
            return View(utilisateur);
        }

        // POST: Utilisateurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Utilisateur utilisateur = db.Utilisateurs.Find(id);
            db.Utilisateurs.Remove(utilisateur);
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
