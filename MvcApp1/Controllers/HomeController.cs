﻿using System.Web.Mvc;

namespace MvcApp1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Index");
        }
    }
}