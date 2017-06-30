using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetMVC.Models;

namespace AspNetMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new MyModel
            {
                Countries = new List<SelectListItem>
                {
                    new SelectListItem { Value = "1", Text="BG" },
                    new SelectListItem { Value = "2", Text="SF" },
                    new SelectListItem { Value = "3", Text="ML" },
                }
            };

            return View(model);
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

        public string NewsList(int page = 1)
        {
            return page.ToString();
        }

        public FileResult GetFile(string fileName)
        {
            return this.File(fileName, "application/octet-stream");
        }
    }
}