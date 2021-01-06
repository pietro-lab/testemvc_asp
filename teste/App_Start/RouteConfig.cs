using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace teste
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "paginas",
                "paginas",
                new { controller = "Paginas", action = "index" }


                );
            routes.MapRoute(
                "paginas_novo",
                "paginas_novo",
                new { controller = "Paginas", action = "Novo" }


                );
            routes.MapRoute(
                "paginas_criar",
                "paginas/criar",
                new { controller = "Paginas", action = "Criar" }


                );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Paginas", action = "Index", id = UrlParameter.Optional }
            );
            
        }
    }
}
