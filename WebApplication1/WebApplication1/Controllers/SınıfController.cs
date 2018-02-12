using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DAT;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SınıfController : Controller
    {
        private MvcContext db = new MvcContext();

        // GET: Sınıf
        public ActionResult Index()
        {
            return View(db.Sınıflar.ToList());
        }

        // GET: Sınıf/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sınıf sınıf = db.Sınıflar.Find(id);
            if (sınıf == null)
            {
                return HttpNotFound();
            }
            return View(sınıf);
        }

        // GET: Sınıf/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sınıf/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ad")] Sınıf sınıf)
        {
            if (ModelState.IsValid)
            {
                db.Sınıflar.Add(sınıf);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sınıf);
        }

        // GET: Sınıf/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sınıf sınıf = db.Sınıflar.Find(id);
            if (sınıf == null)
            {
                return HttpNotFound();
            }
            return View(sınıf);
        }

        // POST: Sınıf/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ad")] Sınıf sınıf)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sınıf).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sınıf);
        }

        // GET: Sınıf/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sınıf sınıf = db.Sınıflar.Find(id);
            if (sınıf == null)
            {
                return HttpNotFound();
            }
            return View(sınıf);
        }

        // POST: Sınıf/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sınıf sınıf = db.Sınıflar.Find(id);
            db.Sınıflar.Remove(sınıf);
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
