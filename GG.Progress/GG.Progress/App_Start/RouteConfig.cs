using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GG.Progress
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("progress1", "", new {controller = "Progress", action = "Index"});
            routes.MapRoute("progress2", "progress2", new {controller = "Progress", action = "Index2"});

        }
    }
}