using AspNetMVCDemos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        public ActionResult Books()
        {
            var data = BooksData
                .GetAll()
                .AsQueryable()
                .Select(BookViewModel.FromBook)
                .ToList();

            return this.View(data);
        }

        public ActionResult Search(string query)
        {
            var result = BooksData
                .GetAll()
                .AsQueryable()
                .Where(b => b.Title.ToLower().Contains(query.ToLower()))
                .Select(BookViewModel.FromBook)
                .ToList();

            return this.PartialView("_BookResult", result);
        }

        public ActionResult ContentById(int id)
        {
            if (!Request.IsAjaxRequest())
            {
                Response.StatusCode = (int)HttpStatusCode.Forbidden;
                return this.Content("Not permeted, only Ajax call");
            }

            var book = BooksData.GetAll().FirstOrDefault(x => x.Id == id);
            if (book == null)
            {
                Response.StatusCode = (int)HttpStatusCode.NotFound;
                return this.Content("Book is not found");
            }

            return this.Content(book.Content);
        }
    }
}