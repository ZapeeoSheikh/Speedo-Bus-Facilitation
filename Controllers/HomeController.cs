﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Speedo_Bus_Facilitation.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult BusNearMe()
        {
            return View();
        }
        public ActionResult AllRoutes()
        {
            return View();
        }
        public ActionResult Terms()
        {
            return View();
        }
        public ActionResult LiveView()
        {
            return View();
        }
    }
}