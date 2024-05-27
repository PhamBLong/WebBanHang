using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHang.Models;
using WebBanHang.Models.EF;

namespace WebBanHang.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var item = db.Categories;
            return View(item);
        }

        public ActionResult ThemMoi()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ThemMoi(Category model)
        {
            if (ModelState.IsValid)
            {
                model.CreateDate = DateTime.Now;
                model.ModifiedDate = DateTime.Now;
                model.alias = WebBanHang.Models.Common.Filter.ChuyenCoDauThanhKhongDau(model.tieude);
                db.Categories.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var item = db.Categories.Find(id);
            return View(item);
        }
         [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category model)
        {
            if (ModelState.IsValid)
            {
                db.Categories.Attach(model);
                model.ModifiedDate = DateTime.Now;
                model.alias = WebBanHang.Models.Common.Filter.ChuyenCoDauThanhKhongDau(model.tieude);
                db.Entry(model).Property(x=>x.tieude).IsModified = true;
                db.Entry(model).Property(x => x.mota).IsModified = true;
                db.Entry(model).Property(x => x.Link).IsModified = true;
                db.Entry(model).Property(x => x.chucvu).IsModified = true;
                db.Entry(model).Property(x => x.alias).IsModified = true;
                db.Entry(model).Property(x => x.tieude_seo).IsModified = true;
                db.Entry(model).Property(x => x.mieuta_seo).IsModified = true;
                db.Entry(model).Property(x => x.tukhoa_seo).IsModified = true;
                db.Entry(model).Property(x => x.ModifiedBy).IsModified = true;
                db.Entry(model).Property(x => x.ModifiedDate).IsModified = true;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var item = db.Categories.Find(id);
            if(item != null)
            {
               //var DeleteItem = db.Categories.Attach(item);
                db.Categories.Remove(item);
                db.SaveChanges();
                return Json(new { success =true });

            }
            return Json(new {success = false});
        }
    }
}