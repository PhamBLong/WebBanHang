using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHang.Models.EF;
using WebBanHang.Models;

namespace WebBanHang.Areas.Admin.Controllers
{
    public class SettingSystemController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/SettingSystem
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Partial_Setting()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult AddSetting(SettingSystemViewModel req)
        {
            SystemSetting set = null;
            var checkTitle = db.SystemSettings.FirstOrDefault(x => x.settingKeys.Contains("SettingTitle"));
            if (checkTitle == null)
            {
                set = new SystemSetting();
                set.settingKeys = "SettingTitle";
                set.settingValue = req.SettingTitle;
                db.SystemSettings.Add(set);
            }
            else
            {
                checkTitle.settingValue = req.SettingTitle;
                db.Entry(checkTitle).State = System.Data.Entity.EntityState.Modified;
            }

            //Logo
            var checkLogo = db.SystemSettings.FirstOrDefault(x => x.settingKeys.Contains("SettingLogo"));
            if (checkLogo == null)
            {
                set = new SystemSetting();
                set.settingKeys = "SettingLogo";
                set.settingValue = req.SettingLogo;
                db.SystemSettings.Add(set);
            }
            else
            {
                checkLogo.settingValue = req.SettingLogo;
                db.Entry(checkLogo).State = System.Data.Entity.EntityState.Modified;
            }
            //Email
            var email = db.SystemSettings.FirstOrDefault(x => x.settingKeys.Contains("SettingEmail"));
            if (email == null )
            {
                set = new SystemSetting();
                set.settingKeys = "SettingEmail";
                set.settingValue = req.SettingEmail;
                db.SystemSettings.Add(set);
            }
            else
            {
                email.settingValue = req.SettingEmail;
                db.Entry(email).State = System.Data.Entity.EntityState.Modified;
            }

            //Hotline
            var Hotline = db.SystemSettings.FirstOrDefault(x => x.settingKeys.Contains("SettingHotline"));
            if (Hotline == null)
            {
                set = new SystemSetting();
                set.settingKeys = "SettingHotline";
                set.settingValue = req.SettingHotline;
                db.SystemSettings.Add(set);
            }
            else
            {
                Hotline.settingValue = req.SettingHotline;
                db.Entry(Hotline).State = System.Data.Entity.EntityState.Modified;
            }

            //TitleSeo
            var TitleSeo = db.SystemSettings.FirstOrDefault(x => x.settingKeys.Contains("SettingTitleSeo"));
            if (TitleSeo == null )
            {
                set = new SystemSetting();
                set.settingKeys = "SettingTitleSeo";
                set.settingValue = req.SettingTitleSeo;
                db.SystemSettings.Add(set);
            }
            else
            {
                TitleSeo.settingValue = req.SettingTitleSeo;
                db.Entry(TitleSeo).State = System.Data.Entity.EntityState.Modified;
            }


            //DescSeo
            var DescSeo = db.SystemSettings.FirstOrDefault(x => x.settingKeys.Contains("SettingDesSeo"));
            if (DescSeo == null)
            {
                set = new SystemSetting();
                set.settingKeys = "SettingDesSeo";
                set.settingValue = req.SettingDesSeo;
                db.SystemSettings.Add(set);
            }
            else
            {
                DescSeo.settingValue = req.SettingDesSeo;
                db.Entry(DescSeo).State = System.Data.Entity.EntityState.Modified;
            }
            //KeySeo
            var KeySeo = db.SystemSettings.FirstOrDefault(x => x.settingKeys.Contains("SettingKeySeo"));
            if (KeySeo == null)
            {
                set = new SystemSetting();
                set.settingKeys = "SettingKeySeo";
                set.settingValue = req.SettingKeySeo;
                db.SystemSettings.Add(set);
            }
            else
            {
                KeySeo.settingValue = req.SettingKeySeo;
                db.Entry(KeySeo).State = System.Data.Entity.EntityState.Modified;
            }

            db.SaveChanges();
            return View("Partial_Setting");
        }

    }
}