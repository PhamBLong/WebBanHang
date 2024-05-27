using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHang.Models;

namespace WebBanHang.Areas.Admin.Controllers
{
    public class StaticalController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/ThongKe
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetStatical(string fromDate , string toDate)
        {
            var query = from o in db.DonHangs
                        join od in db.ChiTietDHes
                        on o.Id equals od.OrderId
                        join p in db.SanPhames
                        on od.ProductId equals p.id
                        select new { 
                         CreatedDate = o.CreateDate,
                         Quantity = od.Quantity,
                         Price =od.Price,
                         OriginPrice = p.OriginalPrice
                        };
            if(!string.IsNullOrEmpty(fromDate) )
            {
                DateTime startDate = DateTime.ParseExact(fromDate, "dd/MM/yyyy", null);
                query = query.Where(x => x.CreatedDate >= startDate);
            }
            if (!string.IsNullOrEmpty(toDate))
            {
                DateTime endDate = DateTime.ParseExact(toDate, "dd/MM/yyyy", null);
                query = query.Where(x => x.CreatedDate < endDate);
            }

            var result = query.GroupBy(x => DbFunctions.TruncateTime(x.CreatedDate)).Select(x => new
            {
                Date = x.Key.Value,
                TotalBuy = x.Sum(y => y.Quantity * y.OriginPrice),
                TotalSell = x.Sum(y => y.Quantity * y.Price),

            }).Select(x => new
            {
                Date = x.Date,
                DoanhThu=x.TotalSell,
                LoiNhuan=x.TotalSell-x.TotalBuy
            });
            return Json(new {Data =result},JsonRequestBehavior.AllowGet);
        }
    }
}