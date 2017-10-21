﻿using System.Web.Mvc;

namespace UrlsAndRoutes.Controllers
{
    public class CustomerController : Controller
    {
        [Route("Test")]
        public ActionResult Index()
        {
            ViewBag.Controller = "Customer";
            ViewBag.Action = "Index";
            return View("ActionName");
        }

        [Route("Users/Add/{user}/{id:int}")]
        public string Create(string user, int id)
        {
            return string.Format("User: {0}, ID: {1}", user, id);
        }

        [Route("Users/Add/{user}/{password}")]
        public string ChangePass(string user, string password)
        {
            return string.Format("ChangePass Method - User: {0}, Pass: {1}", user, password);
        }

        public ActionResult List()
        {
            ViewBag.Controller = "Customer";
            ViewBag.Action = "List";
            return View("ActionName");
        }
    }
}