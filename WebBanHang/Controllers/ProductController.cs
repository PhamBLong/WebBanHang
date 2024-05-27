using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHang.Models;

namespace WebBanHang.Controllers
{
    public class ProductController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var items = db.SanPhames.ToList();
            return View(items);
        }

        public ActionResult Detail(string alias, int id)
        {
            var item = db.SanPhames.Find(id);
            if (item != null)
            {
                db.SanPhames.Attach(item);
                item.ViewCount = item.ViewCount + 1;
                db.Entry(item).Property(x=>x.ViewCount).IsModified = true;
                db.SaveChanges();
            }
            var countReview = db.Review.Where(x=>x.ProductId==id).Count();
            ViewBag.CountReview = countReview;
            return View(item);
        }

        public ActionResult ProductCategory(string alias, int id)
        {
            var items = db.SanPhames.ToList();
            if (id >0)
            {
                items = items.Where(x => x.maloaisp == id).ToList();
            }
            var cate =db.LoaiSpes.Find(id);
            if (cate != null)
            {
                ViewBag.CateName = cate.Title;
            }
            ViewBag.CateID = id;
            return View(items);
        }

        public ActionResult Partial_ItemByCateID()
        {
            var items = db.SanPhames.Where(x => x.isHome && x.isActive).Take(12).ToList();
            return PartialView(items);
        }
      

        public ActionResult Partial_ProductSale()
        {
            var items = db.SanPhames.Where(x => x.isSale && x.isActive).Take(12).ToList();
            return PartialView(items);
        }

      
    }
}