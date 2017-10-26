using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Mvc.Routing.Constraints;
using UrlsAndRoutes.Infrastructure;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapMvcAttributeRoutes();

            routes.Add(new LegacyRoute("∼/articles/Windows_3.1_Overview.html","∼/old/.NET_1.0_Class_Library"));
        
            routes.MapRoute("MyRoute", "{controller}/{action}");
            routes.MapRoute("MyOtherRoute", "App/{action}", new { controller = "Home" });

            //routes.MapRoute("NewRoute", "App/Do{action}", new { controller = "Home" });

            //routes.MapRoute("MyRoute", "{controller}/{action}/{id}", 
            //    new { controller = "Home", action = "Index", id = UrlParameter.Optional });
            
            //routes.MapRoute("Default", "{controller}/{action}/{id}",
            //    new {controller = "Home", action = "Index", id = UrlParameter.Optional },
            //    new[] { "UrlsAndRoutes.Controllers" });

            //    routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //    routes.MapRoute(
            //        name: "Default",
            //        url: "{controller}/{action}/{id}",
            //        defaults: new { action = "Index", id = UrlParameter.Optional }
            //    );

            //routes.MapRoute("ShopSchema2", "Shop/OldAction", new { controller = "Home", action = "Index" });
            //routes.MapRoute("ShopSchema", "Shop/{action}", new { controller = "Home" });
            //routes.MapRoute("", "X{controller}/{action}");
            //routes.MapRoute("MyRoute", "{controller}/{action}", new { controller = "Home", action = "Index" });
            //routes.MapRoute("", "Public/{controller}/{action}", new { controller = "Home", action = "Index" });

            //Route myRoute = routes.MapRoute("AddContollerRoute", "Home/{action}/{id}/{*catchall}",
            //                                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            //                                new[] { "URLsAndRoutes.AdditionalControllers" });
            //myRoute.DataTokens["UseNamespaceFallback"] = false;

            //routes.MapRoute("ChromeRoute", "{*catchall}",
            //    new { Controller = "Home", action = "Index" },
            //    new { customContraint = new UserAgentConstraint("Chrome") },
            //    new[] { "UrlsAndRoutes.AdditionalControllers" });

            //routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}",
            //    new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            //    new { controller = "^H.*", action = "Index|About", httpMethod = new HttpMethodConstraint("GET"),
            //          id = new CompoundRouteConstraint(new IRouteConstraint[] { new AlphaRouteConstraint(), new MinLengthRouteConstraint(6) })},
            //    new[] { "URLsAndRoutes.Controllers" });
        }
    }
}


