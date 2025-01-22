using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCApplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();

            //routes.MapRoute(
            //    name: "AllEmployee",
            //    url: "Employee",
            //    defaults: new { controller = "Employee", action = "GetAllEmployee", id = UrlParameter.Optional }
            //    ); 
            //routes.MapRoute(
            //    name: "Employee",
            //    url: "Employee/{id}",
            //    defaults: new { controller = "Employee", action = "GetEmployee", id = UrlParameter.Optional }
            //    );
            //routes.MapRoute(
            //    name: "EmployeeAddress",
            //    url: "Employee/Address/{id}",
            //    defaults: new { controller = "Employee", action = "GetEmployeeAddress", id = UrlParameter.Optional },
            //    constraints: new {id = @"\d+"}

            //    );



            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
