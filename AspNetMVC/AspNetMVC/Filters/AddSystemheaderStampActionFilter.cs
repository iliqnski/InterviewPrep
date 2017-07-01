namespace AspNetMVC.Filters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class AddSystemheaderStampActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Headers.Add("X-Powered-By", "My shiny CMS system v1.0");
            base.OnActionExecuting(filterContext);
        }
    }
}