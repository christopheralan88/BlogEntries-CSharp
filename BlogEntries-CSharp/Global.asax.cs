using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BlogEntries_CSharp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        //public static void RegisterRoutes(RouteCollection routes)
        //{
        //    routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

        //    routes.MapRoute(
        //        "Default",                                              // Route name
        //        "{controller}/{action}",                           // URL with parameters
        //        new { controller = "BlogEntry", action = "Index" }      // Parameter defaults
        //    );

        //    routes.MapRoute(
        //        "Details",                                                      // Route name
        //        "{controller}/{action}/{slug}",                                 // URL with parameters
        //        new { controller = "BlogEntry", slug = UrlParameter.Optional, action = "Details" }   // Parameter defaults
        //    );

        //    routes.MapRoute(
        //        "SignIn",                                                      // Route name
        //        "{controller}/{action}",                                 // URL with parameters
        //        new { controller = "BlogEntry", action = "SignIn" }   // Parameter defaults
        //    );

        //    routes.MapRoute(
        //        "AttemptLogIn",                                                      // Route name
        //        "{controller}/{action}",                                 // URL with parameters
        //        new { controller = "BlogEntry", action = "AttemptLogIn" }   // Parameter defaults
        //    );
        //}

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //RegisterRoutes(RouteTable.Routes);
        }
    }
}
