using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AspNetMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //ignores everything after *pathInfo
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "NewsList",
                url: "News/{page}",
                defaults: new { controller = "Home", action = "NewsList", page = UrlParameter.Optional },
                constraints: new { page = @"[0-9]*", isChrome = new IsChromeUserAgentRouteConstraint() }
            );

            //unique name:, route pattern(url): 
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }

    public class IsChromeUserAgentRouteConstraint : IRouteConstraint
    {
        public bool Match(HttpContextBase httpContext, 
                    Route route, string parameterName, 
                    RouteValueDictionary values, 
                    RouteDirection routeDirection)
        {
            return httpContext.Request.UserAgent.Contains("Chrome");
        }
    }
}
