using System;
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
    public class ViewModelAllItemsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ViewModelAllItems
        public ActionResult Index()
        {
            ViewModelAllItems mymodel = new ViewModelAllItems();
            mymodel.Games = db.Games.ToList();
            mymodel.Keyboards = db.Keyboards.ToList();
            return View(mymodel);
        }

        // GET: ViewModelAllItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ViewModelAllItems viewModelAllItems = db.ViewModelAllItems.Find(id);
            if (viewModelAllItems == null)
            {
                return HttpNotFound();
            }
            return View(viewModelAllItems);
        }

        // GET: ViewModelAllItems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ViewModelAllItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID")] ViewModelAllItems viewModelAllItems)
        {
            if (ModelState.IsValid)
            {
                db.ViewModelAllItems.Add(viewModelAllItems);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(viewModelAllItems);
        }

        // GET: ViewModelAllItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ViewModelAllItems viewModelAllItems = db.ViewModelAllItems.Find(id);
            if (viewModelAllItems == null)
            {
                return HttpNotFound();
            }
            return View(viewModelAllItems);
        }

        // POST: ViewModelAllItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID")] ViewModelAllItems viewModelAllItems)
        {
            if (ModelState.IsValid)
            {
                db.Entry(viewModelAllItems).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(viewModelAllItems);
        }

        // GET: ViewModelAllItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ViewModelAllItems viewModelAllItems = db.ViewModelAllItems.Find(id);
            if (viewModelAllItems == null)
            {
                return HttpNotFound();
            }
            return View(viewModelAllItems);
        }

        // POST: ViewModelAllItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ViewModelAllItems viewModelAllItems = db.ViewModelAllItems.Find(id);
            db.ViewModelAllItems.Remove(viewModelAllItems);
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
