﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IRProject.Models;

namespace IRProject.Controllers
{
    public class KeyboardsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Keyboards
        public ActionResult Index()
        {
            return View(db.Keyboards.ToList());
        }

        // GET: Keyboards/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Keyboard keyboard = db.Keyboards.Find(id);
            if (keyboard == null)
            {
                return HttpNotFound();
            }
            return View(keyboard);
        }

        // GET: Keyboards/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Keyboards/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Color,ShortDescription,ImagePath")] Keyboard keyboard)
        {
            if (ModelState.IsValid)
            {
                db.Keyboards.Add(keyboard);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(keyboard);
        }

        // GET: Keyboards/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Keyboard keyboard = db.Keyboards.Find(id);
            if (keyboard == null)
            {
                return HttpNotFound();
            }
            return View(keyboard);
        }

        // POST: Keyboards/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Color,ShortDescription,ImagePath")] Keyboard keyboard)
        {
            if (ModelState.IsValid)
            {
                db.Entry(keyboard).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(keyboard);
        }

        // GET: Keyboards/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Keyboard keyboard = db.Keyboards.Find(id);
            if (keyboard == null)
            {
                return HttpNotFound();
            }
            return View(keyboard);
        }

        // POST: Keyboards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Keyboard keyboard = db.Keyboards.Find(id);
            db.Keyboards.Remove(keyboard);
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
