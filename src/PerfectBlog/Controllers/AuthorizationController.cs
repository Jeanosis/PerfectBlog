using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PerfectBlog.DAL;
using PerfectBlog.Models;

namespace PerfectBlog.Controllers
{
    public class AuthorizationController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Authorized = true;

            return View();
        }

        /*[HttpGet]
        public ActionResult Index(bool authorized = true)
        {
            ViewBag.Authorized = authorized;
            return View();
        }*/

        [HttpPost]
        public ActionResult Index(String login, String password)
        {
            var dbUser = RepositoryService.Repository.GetUserByLogin(login);
            
            if (dbUser.Password == new User() { Password = password }.Password)
            {
                AuthorizationManager.LoggedUser = dbUser;
                System.Diagnostics.Debug.WriteLine("AZAZA");
                return RedirectToAction("Index", "Home");//, new { user = dbUser });
            }
            else
            {
                ViewBag.Authorized = false;

                return View();
            }

        }
    }
}
