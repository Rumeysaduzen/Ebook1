using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Ebook1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(name: "Login", url: "Login", defaults: new { controller = "Login1", action = "Login" });
            routes.MapRoute(name: "ComputerEngineer", url: "ComputerEngineer", defaults: new { controller = "Department", action = "ComputerEngineer" });
            routes.MapRoute(name: "Algoritmalar", url: "Algoritmalar", defaults: new { controller = "Department", action = "Algoritmalar" });
            routes.MapRoute(name: "BookAdd1", url: "BookAdd1", defaults: new { controller = "BookAdd", action = "BookAdd1" });
            routes.MapRoute(name: "Department1", url: "Department1", defaults: new { controller = "Department", action = "Department1" });



            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "Ebook.Controllers" }
            );

            routes.MapRoute(name: "Home", url: "", defaults: new { controller = "Home", action = "Index" });
        }
    }
}