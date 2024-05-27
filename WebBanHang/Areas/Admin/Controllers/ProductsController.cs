using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHang.Models;
using WebBanHang.Models.EF;

namespace WebBanHang.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin,Employee")]
    public class ProductsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index(int? page)
        {
            IEnumerable<SanPham> items = db.SanPhames.OrderByDescending(x => x.id);
            var pageSize = 5;
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

        public ActionResult Add()
        {
            ViewBag.LoaiSP = new SelectList(db.LoaiSpes.ToList(),"id","Title");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(SanPham model, List<string> Images ,List<int> rDefault)
        {
          if(ModelState.IsValid)
            {
                if(Images!=null && Images.Count > 0)
                {
                    for(int i = 0;i < Images.Count; i++)
                    {
                        if (i + 1 == rDefault[0])
                        {
                            model.hinhanh = Images[i]; 
                            model.HinhanhSPs.Add(new HinhanhSP
                            {
                                ProductID = model.id,
                                Image = Images[i],
                                isDefault = true
                            });
                        }
                        else
                        {
                            model.HinhanhSPs.Add(new HinhanhSP
                            {
                                ProductID = model.id,
                                Image = Images[i],
                                isDefault = false
                            });
                        }
                    }
                }
                model.CreateDate = DateTime.Now;
                model.ModifiedDate = DateTime.Now;
                if (string.IsNullOrEmpty(model.tieude_seo))
                {
                    model.tieude_seo = model.tensanpham;
                }
                if(string.IsNullOrEmpty(model.alias))
                    model.alias = WebBanHang.Models.Common.Filter.FilterChar(model.tensanpham);
                db.SanPhames.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LoaiSP = new SelectList(db.LoaiSpes.ToList(), "id", "Title");
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            ViewBag.LoaiSP = new SelectList(db.LoaiSpes.ToList(), "id", "Title");
            var item = db.SanPhames.Find(id);
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SanPham model)
        {
            if (ModelState.IsValid)
            {
                model.ModifiedDate = DateTime.Now;
                model.alias = WebBanHang.Models.Common.Filter.FilterChar(model.tensanpham);
                db.SanPhames.Attach(model);
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var item = db.SanPhames.Find(id);
            if (item != null)
            {
                var checkImg = item.HinhanhSPs.Where(x => x.ProductID == item.id);
                if (checkImg != null)
                {
                    foreach (var img in checkImg)
                    {
                        db.HinhanhSPes.Remove(img);
                        db.SaveChanges();
                    }
                }
                db.SanPhames.Remove(item);
                db.SaveChanges();
                return Json(new { success = true });
            }

            return Json(new { success = false });
        }

        [HttpPost]
        public ActionResult IsActive(int id)
        {
            var item = db.SanPhames.Find(id);
            if (item != null)
            {
                item.isActive = !item.isActive;
                db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return Json(new { success = true, isActive = item.isActive });
            }

            return Json(new { success = false });
        }

        [HttpPost]
        public ActionResult IsHome(int id)
        {
            var item = db.SanPhames.Find(id);
            if (item != null)
            {
                item.isHome = !item.isHome;
                db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return Json(new { success = true, isHome = item.isHome });
            }

            return Json(new { success = false });
        }
        [HttpPost]
        public ActionResult IsSale(int id)
        {
            var item = db.SanPhames.Find(id);
            if (item != null)
            {
                item.isSale = !item.isSale;
                db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return Json(new { success = true, isSale = item.isSale });
            }

            return Json(new { success = false });
        }

    }
}