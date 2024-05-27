using PagedList.Mvc;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using WebBanHang.Models;
using WebBanHang.Models.EF;

namespace WebBanHang.Controllers
{
    public class NewController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: News
        public ActionResult Index(int? page)
        {
            IEnumerable<TinTuc> items = db.TinTucs.OrderByDescending(x => x.CreateDate);
            var pageSize = 7;
            if (page == null)
            {
                page = 1;
            }
            var pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            items = items.ToPagedList(pageIndex, pageSize);
            ViewBag.PageSize = pageSize;
            ViewBag.Page = page;
            return View(items);
        }


        public ActionResult Details(int id)
        {
            var item = db.TinTucs.Find(id);
            return View(item);
        }

        public ActionResult Partial_News_Home()
        {
            var items = db.QuangCaos.Take(3).ToList();
            return PartialView(items);
        }
    }
}