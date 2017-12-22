using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BusAndModel.Model;

namespace WebTour.Controllers
{
    public class DoanKhachesController : Controller
    {
        private Model1Container db = new Model1Container();

        // GET: DoanKhaches
        public ActionResult Index()
        {
            var doanKhaches = db.DoanKhaches.Include(d => d.Tour);
            return View(doanKhaches.ToList());
        }

        // GET: DoanKhaches/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoanKhach doanKhach = db.DoanKhaches.Find(id);
            if (doanKhach == null)
            {
                return HttpNotFound();
            }
            return View(doanKhach);
        }

        // GET: DoanKhaches/Create
        public ActionResult Create()
        {
            ViewBag.TourId = new SelectList(db.Tours, "Id", "TenGoi");
            return View();
        }

        // POST: DoanKhaches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,TenGoi,NgayKhoiHanh,NgayKetThuc,TongKS,TongAn,TongPT,TongKhac,TourId")] DoanKhach doanKhach)
        {
            if (ModelState.IsValid)
            {
                db.DoanKhaches.Add(doanKhach);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TourId = new SelectList(db.Tours, "Id", "TenGoi", doanKhach.TourId);
            return View(doanKhach);
        }

        // GET: DoanKhaches/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoanKhach doanKhach = db.DoanKhaches.Find(id);
            if (doanKhach == null)
            {
                return HttpNotFound();
            }
            ViewBag.TourId = new SelectList(db.Tours, "Id", "TenGoi", doanKhach.TourId);
            return View(doanKhach);
        }

        // POST: DoanKhaches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TenGoi,NgayKhoiHanh,NgayKetThuc,TongKS,TongAn,TongPT,TongKhac,TourId")] DoanKhach doanKhach)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doanKhach).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TourId = new SelectList(db.Tours, "Id", "TenGoi", doanKhach.TourId);
            return View(doanKhach);
        }

        // GET: DoanKhaches/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoanKhach doanKhach = db.DoanKhaches.Find(id);
            if (doanKhach == null)
            {
                return HttpNotFound();
            }
            return View(doanKhach);
        }

        // POST: DoanKhaches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DoanKhach doanKhach = db.DoanKhaches.Find(id);
            db.DoanKhaches.Remove(doanKhach);
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
