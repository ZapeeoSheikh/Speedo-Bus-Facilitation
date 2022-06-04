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
            List<HomeRoutes> homeRoute = db.HomeRoutes.ToList();
            return View(homeRoute);
        }
        public ActionResult BusNearMe()
        {
            return View();
        }
        public ActionResult AllRoutes()
        {
            List<Route> routes = db.routes.ToList();
            return View(routes);
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
        public ActionResult Route(int Id)
        {
            Route route = db.routes.Where(x => x.Id == Id).FirstOrDefault();
            return View(route);
        }

    }
}