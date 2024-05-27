using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHang.Models;

namespace WebBanHang.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        private ApplicationDbContext db = new ApplicationDbContext ();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MenuTop()
        {

            var items = db.Categories.OrderBy(x => x.chucvu).ToList();
            return PartialView("_MenuTop", items);
        }

        public ActionResult MenuProductCategory()
        {
            var items = db.LoaiSpes.ToList();
            return PartialView("_MenuProductCategory", items);
        }
        public ActionResult MenuLeft(int? id)
        {
            if (id != null)
            {
                ViewBag.CateID = id;
            }
            var items = db.LoaiSpes.ToList();
            return PartialView("_MenuLeft", items);
        }
        public ActionResult MenuArrival()
        {
            var items = db.LoaiSpes.ToList();
            return PartialView("_MenuArrival", items);
        }
    }
}