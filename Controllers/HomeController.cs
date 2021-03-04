﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject_Raihan.Controllers
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
        public ActionResult Admin()
        {
            ViewBag.Message = "Your Admin page.";

            return View();
        }
        public ActionResult HomeTeplete()
        {
            ViewBag.Message = "Your HomeTeplete page.";

            return View();
        }
    }
}