using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace URLShortener
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "URL",
                url: "URL/{NewURL}-{APIKey}",
                defaults: new { controller = "URL", action = "Index", NewURL = UrlParameter.Optional, APIKey = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "Default",
                url: "{LinkID}",
                defaults: new { controller = "Default", action = "Index", LinkID = UrlParameter.Optional }
            );
        }
    }
}
