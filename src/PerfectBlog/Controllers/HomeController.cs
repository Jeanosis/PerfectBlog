using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PerfectBlog.DAL;
using PerfectBlog.Models;
using System.Diagnostics;

namespace PerfectBlog.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Blogs/

        public ActionResult Index()
        {
            if (AuthorizationManager.LoggedUser == null)
                return RedirectToAction("Index", "Authorization");

            ViewBag.Blogs = RepositoryService.Repository.GetAllBlogs();
            
            return View();
        }

        /*[HttpGet]
        public ActionResult Index(User user)
        {
            if (AuthorizationManager.LoggedUser == null)
                return RedirectToAction("Index", "Home");

            ViewBag.Blogs = RepositoryService.Repository.GetAllBlogs();
            
            return View();
        }*/

    }
}
