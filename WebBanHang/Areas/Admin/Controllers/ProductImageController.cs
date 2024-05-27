using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHang.Models;
using WebBanHang.Models.EF;

namespace WebBanHang.Areas.Admin.Controllers
{
    public class ProductImageController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index(int id)
        {
            ViewBag.ProductId = id;
            var items = db.HinhanhSPes.Where(x => x.ProductID == id).ToList();
            return View(items); 
        }

        [HttpPost]
        public ActionResult AddImage(int productId, string url)
        {
            db.HinhanhSPes.Add(new HinhanhSP
            {
                ProductID = productId,
                Image = url,
                isDefault = false
            });
            db.SaveChanges();
            return Json(new { Success = true });
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var item =  db.HinhanhSPes.Find(id);
            db.HinhanhSPes.Remove(item);
            db.SaveChanges();
            return Json(new { success = true});
        }
    }
}