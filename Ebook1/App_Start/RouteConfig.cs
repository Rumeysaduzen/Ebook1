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

            routes.MapRoute(name: "Signout", url: "Signout", defaults: new { controller = "Login1", action = "Signout" });
            routes.MapRoute(name: "LoginK", url: " /Login1/LoginK", defaults: new { controller = "Login1", action = "LoginK" });
            routes.MapRoute(name: "LoginG", url: "LoginG", defaults: new { controller = "Login1", action = "LoginG" });
            routes.MapRoute(name: "ComputerEngineer", url: "ComputerEngineer", defaults: new { controller = "Department", action = "ComputerEngineer" });
            routes.MapRoute(name: "Algoritmalar", url: "Algoritmalar", defaults: new { controller = "Department", action = "Algoritmalar" });
            routes.MapRoute(name: "BookAdd1", url: "BookAdd1", defaults: new { controller = "BookAdd", action = "BookAdd1" });
            routes.MapRoute(name: "Department1", url: "Department1", defaults: new { controller = "Department", action = "Department1" });
            routes.MapRoute(name: "Product", url: "Product", defaults: new { controller = "Product1", action = "Product" });



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