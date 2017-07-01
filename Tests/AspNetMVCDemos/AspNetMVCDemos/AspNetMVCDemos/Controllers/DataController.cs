using AspNetMVCDemos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCDemos.Controllers
{
    public class DataController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return this.View();
        }

        //[HttpPost]
        //public ActionResult Index(int number, string text)
        //{
        //    return this.View();
        //}

        [HttpPost]
        public ActionResult Index(PersonalDataViewModel model)
        {
            return this.View();
        }
    }
}