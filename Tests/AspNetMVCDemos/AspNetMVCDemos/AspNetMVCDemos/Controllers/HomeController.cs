using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCDemos.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ServerTime()
        {
            var isAjax = Request.IsAjaxRequest();
            Thread.Sleep(2000);
            return this.Content(isAjax + " " + DateTime.Now.ToLongTimeString());
        }

        public ActionResult AjaxActionLink()
        {
            return this.View();
        }
    }
}