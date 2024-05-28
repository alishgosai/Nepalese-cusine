using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalProject272.Data;
using FinalProject272.Models;

namespace FinalProject272.Controllers
{
    public class ContactViewModelsController : Controller
    {
        private RestaurantSystemContext db = new RestaurantSystemContext();

        // GET: ContactViewModels
        public ActionResult Index()
        {
            return View(db.ContactViewModels.ToList());
        }

        // GET: ContactViewModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactViewModel contactViewModel = db.ContactViewModels.Find(id);
            if (contactViewModel == null)
            {
                return HttpNotFound();
            }
            return View(contactViewModel);
        }

        // GET: ContactViewModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactViewModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Email,Number,Message")] ContactViewModel contactViewModel)
        {
            if (ModelState.IsValid)
            {
                db.ContactViewModels.Add(contactViewModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contactViewModel);
        }

        // GET: ContactViewModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactViewModel contactViewModel = db.ContactViewModels.Find(id);
            if (contactViewModel == null)
            {
                return HttpNotFound();
            }
            return View(contactViewModel);
        }

        // POST: ContactViewModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Email,Number,Message")] ContactViewModel contactViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contactViewModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contactViewModel);
        }

        // GET: ContactViewModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactViewModel contactViewModel = db.ContactViewModels.Find(id);
            if (contactViewModel == null)
            {
                return HttpNotFound();
            }
            return View(contactViewModel);
        }

        // POST: ContactViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ContactViewModel contactViewModel = db.ContactViewModels.Find(id);
            db.ContactViewModels.Remove(contactViewModel);
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
