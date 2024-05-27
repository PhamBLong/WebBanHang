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
    [Authorize]
    public class WishListController : Controller
    {
      
        // GET: WishList
        public ActionResult Index(int? page)
        {
            var pageSize = 3;
            if (page == null)
            {
                page = 1;
            }
            IEnumerable<Wishlist> items = db.Wishlists.Where(x => x.UserName == User.Identity.Name).OrderByDescending(x => x.CreatedDate);
            var pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            items = items.ToPagedList(pageIndex, pageSize);
            ViewBag.PageSize = pageSize;
            ViewBag.Page = page;
           
            return View(items);
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult PostWishList (int ProductId)
        {
            if (Request.IsAuthenticated==false)
            {
                return Json(new { Success = false,Message ="Bạn chưa đăng nhập " });
            }
            var checkItem = db.Wishlists.FirstOrDefault(x=>x.ProductId == ProductId && x.UserName==User.Identity.Name);
            if(checkItem != null)
            {
                return Json(new { Success = false, Message = "Sản phẩm đã được thêm vào yêu thích " });
            }
            var item = new Wishlist();
            item.ProductId = ProductId;
            item.UserName = User.Identity.Name;
            item.CreatedDate = DateTime.Now;
            db.Wishlists.Add(item);
            db.SaveChanges();
            return Json(new { Success = true });
        }
        private ApplicationDbContext db =  new ApplicationDbContext();

        [HttpPost]
        [AllowAnonymous]
        public ActionResult PostDeleteWishList(int ProductId)
        {
            var checkItem = db.Wishlists.FirstOrDefault(x => x.ProductId == ProductId && x.UserName == User.Identity.Name);
            if (checkItem != null)
            {
                db.Wishlists.Remove(checkItem);
                db.SaveChanges();
                return Json(new { Success = true, Message = "Sản phẩm đã được xóa khỏi yêu thích của bạn " });
            }
            return Json(new { Success = false, Message ="Xóa khỏi yêu thích không thành công . Vui lòng thử lại !" });
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Delete(int id)
        {
            var item = db.Wishlists.Find(id);
            if (item != null)
            {
                db.Wishlists.Remove(item);
                db.SaveChanges();
                return Json(new { success = true , });

            }
            return Json(new { success = false });
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

    }
}