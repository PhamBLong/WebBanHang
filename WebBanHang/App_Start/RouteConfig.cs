﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebBanHang
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

             routes.MapRoute(
             name: "CategoryProduct",
             url: "danh-muc-san-pham/{alias}-{id}",
             defaults: new { controller = "Product", action = "ProductCategory", id = UrlParameter.Optional },
             namespaces: new[] { "WebBanHangOnline.Controllers" }
                 );
            routes.MapRoute(
            name: "BaiViet",
            url: "arcticle/{alias}",
            defaults: new { controller = "Arcticles", action = "Index", alias = UrlParameter.Optional },
            namespaces: new[] { "WebBanHangOnline.Controllers" }
                );
            routes.MapRoute(
             name: "detailProducts",
             url: "chi-tiet/{alias}-p{id}",
             defaults: new { controller = "Product", action = "Detail", alias = UrlParameter.Optional },
             namespaces: new[] { "WebBanHangOnline.Controllers" }
              );
            routes.MapRoute(
             name: "Products",
             url: "san pham",
             defaults: new { controller = "Product", action = "Index", alias = UrlParameter.Optional },
             namespaces: new[] { "WebBanHangOnline.Controllers" }
             );
            routes.MapRoute(
            name: "NewsList",
            url: "tin-tuc",
            defaults: new { controller = "New", action = "Index", alias = UrlParameter.Optional },
            namespaces: new[] { "WebBanHangOnline.Controllers" }
            );

            routes.MapRoute(
           name: "DetailNews",
           url: "{alias}-n{id}",
           defaults: new { controller = "New", action = "Details", id = UrlParameter.Optional },
           namespaces: new[] { "WebBanHangOnline.Controllers" }
           );

            routes.MapRoute(
            name: "ShoppingCart",
            url: "gio-hang",
            defaults: new { controller = "ShoppingCart", action = "Index", alias = UrlParameter.Optional },
            namespaces: new[] { "WebBanHangOnline.Controllers" }
                );
            routes.MapRoute(
           name: "CheckOut",
           url: "thanh-toan",
           defaults: new { controller = "ShoppingCart", action = "CheckOut", alias = UrlParameter.Optional },
           namespaces: new[] { "WebBanHangOnline.Controllers" }
               );
            routes.MapRoute(
           name: "Contact",
           url: "lien he",
           defaults: new { controller = "Contact", action = "Index", alias = UrlParameter.Optional },
           namespaces: new[] { "WebBanHangOnline.Controllers" }
               );

            routes.MapRoute(
             name: "Default",
             url: "{controller}/{action}/{id}",
             defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
             namespaces: new[] { "WebBanHang.Controllers" }
            );
        }
    }
}
