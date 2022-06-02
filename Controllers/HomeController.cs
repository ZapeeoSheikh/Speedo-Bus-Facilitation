using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Speedo_Bus_Facilitation.Models;

namespace Speedo_Bus_Facilitation.Controllers
{
    public class HomeController : Controller
    {
        SpeedoContext db = new SpeedoContext();
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
        public ActionResult BusStop()
        {
            List<BusStop> busStops = db.busStop.ToList();
            return View(busStops);

        }
        public ActionResult Jobs()
        {
            return View();
        }
        public ActionResult Recharge()
        {
            return View();
        }
        public ActionResult Card()
        {
            return View();
        }
        public ActionResult Token()
        {
            return View();
        }
        public ActionResult TravelGuide()
        {
            return View();
        }
        public ActionResult Route()
        {
            return View();
        }

    }
}