using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using BusAndModel.Model;
using BusAndModel.BUS;

namespace WebTour.Controllers
{
    public class KhachHangsController : Controller
    {
        KhachhangBus bus = new KhachhangBus();

        // GET: KhachHangs
        public ActionResult Index()
        {
            List<KhachHang> list = bus.getList();
            return View(list);
        }

        // GET: KhachHangs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhachHang khachHang = bus.FindbyId(id);
            if (khachHang == null)
            {
                return HttpNotFound();
            }
            return View(khachHang);
        }

        // GET: KhachHangs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KhachHangs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,HoTen,CMND,DiaChi,SDT,GioiTinh")] KhachHang khachHang)
        {
            if (ModelState.IsValid)
            {
                bus.CreateKhachHang(khachHang);
                return RedirectToAction("Index");
            }

            return View(khachHang);
        }

        // GET: KhachHangs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhachHang khachHang = bus.FindbyId(id);
            if (khachHang == null)
            {
                return HttpNotFound();
            }
            return View(khachHang);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,HoTen,CMND,DiaChi,SDT,GioiTinh")] KhachHang khachHang)
        {
            if (ModelState.IsValid)
            {
                bus.UpdateKhachHang(khachHang);
                return RedirectToAction("Index");
            }
            return View(khachHang);
        }
        public ActionResult Delete(int? id)
        {
            bus.DeleteKhachHang(id);
            return RedirectToAction("Index");
        }

    }
}
