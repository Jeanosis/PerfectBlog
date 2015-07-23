using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PerfectBlog.Models;

namespace PerfectBlog.Controllers
{
    public class BlogController : Controller
    {
        //
        // GET: /Blog/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Index(Blog blog)
        {
            ViewBag.Blog = blog;

            return View();
        }

    }
}
