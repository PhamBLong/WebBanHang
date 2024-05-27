using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHang.Models;
using PagedList;

namespace WebBanHang.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class OrderController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/Order
        public ActionResult Index(int? page)
        {
            var item = db.DonHangs.OrderByDescending(x=>x.CreateDate).ToList();

            if(page == null)
            {
                page = 1;

            }
            var pageNumber = page ?? 1;
            var pageSize = 10;
            ViewBag.PageSize = pageSize;
            ViewBag.Page = pageNumber;

            return View(item.ToPagedList(pageNumber,pageSize));
        }

        public ActionResult View(int id)
        {
            var item = db.DonHangs.Find(id);
            return View(item);
        }

        public ActionResult Partial_SanPham(int id)
        {
            var items = db.ChiTietDHes.Where(x => x.OrderId == id).ToList();
            return PartialView(items);
        }
        [HttpPost]
        public ActionResult UpdateTT(int id ,int trangthai)
        {
            var item = db.DonHangs.Find(id);
            if(item!=null)
            {
                db.DonHangs.Attach(item);
                item.TypePayment = trangthai;
                db.Entry(item).Property(x=>x.TypePayment).IsModified = true;
                db.SaveChanges();
                return Json(new {messages="Success",Success = true});

            }
            return Json(new { messages = "Fail", Success = false });
        }
    }
}