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
        AppDbContext db = new AppDbContext();
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
            List<Route> routes = db.Routes.ToList();
            return View(routes);
            
        }
        public ActionResult Terms()
        {
            return View();
        }
        public ActionResult LiveView(int Id)
        {
            //Route route = db.Routes.Where(x => x.Id == Id).FirstOrDefault();
            return View();
        }
        public ActionResult BusStop(string query)
        {
            var routes = db.Routes.Where(x=>x.Name.Contains(query)).FirstOrDefault();
            List<BusStop> busStopsByRoute = new List<BusStop>();
            if (routes != null)
            {
                busStopsByRoute = db.BusStop.Where(x => x.RouteNo == routes.Name ).ToList();
                foreach (var busStop in busStopsByRoute)
                {
                    busStop.ListBusStop = db.BusStop.Take(20).ToList();
                }
                return View(busStopsByRoute);
            }
            else
            {
                List<BusStop> busStops = db.BusStop.Where(x => x.Name.Contains(query)).ToList();
                if(busStops.Count > 0)
                {
                    foreach (var busStop in busStops)
                    {
                        busStop.ListBusStop = db.BusStop.Take(20).ToList();
                    }
                    return View(busStops);
                }
                else {
                    var bs = new BusStop();
                    bs.ListBusStop = db.BusStop.Take(20).ToList();
                    return View(bs);
                }

            }
        }
        public ActionResult Jobs()
        {
            List<Jobs> jobs = db.Jobs.ToList();
            return View(jobs);
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
           // Route route = db.Routes.Where(x => x.Id == Id).FirstOrDefault();
            return View();
            
        }

    }
}