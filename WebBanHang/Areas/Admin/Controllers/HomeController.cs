﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebBanHang.Areas.Admin.Controllers
{
    [Authorize(Roles ="Admin , Employee")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
    }
}