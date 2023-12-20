using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Speedo_Bus_Facilitation.Models;
using Speedo_Bus_Facilitation.ViewModels;

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
            List<Route> routes = db.Routes.ToList();
            return View(routes);
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
            var routeslist = db.Routes.ToList();
            var routes = db.Routes.Where(x=>x.RouteNo.Contains(query)).FirstOrDefault();
            List<BusStop> busStopsByRoute = new List<BusStop>();
            if (routes != null)
            {
                busStopsByRoute = db.BusStop.Where(x => x.RouteNo == routes.RouteNo).ToList();
                foreach (var busStop in busStopsByRoute)
                {
                    busStop.ListBusStop = db.BusStop.Take(20).ToList();
                }
                return View(busStopsByRoute);
            }
            else
            {
                List<BusStop> busStops = db.BusStop.Where(x => x.Name.Contains(query)).ToList();
                List<BusStop> busStopsL = db.BusStop.Where(x => x.BusNo.Contains(query)).ToList();
                if(busStops.Count > 0)
                {
                    foreach (var busStop in busStops)
                    {
                        busStop.ListBusStop = db.BusStop.Take(20).ToList();
                    }
                    return View(busStops);
                } else if (busStopsL.Count>0) {
                    return View(busStopsL.Distinct().ToList()); 
                }
                else {
                    var bs = new BusStop();
                    bs.ListBusStop = db.BusStop.Take(20).ToList();
                    foreach(var busStop in bs.ListBusStop.ToList()) {
                        if (busStop.RouteNo.Contains(","))
                        {
                            var newstops =  busStop.RouteNo.Split(',');
                            foreach (var newstop in newstops)
                            {
                                busStop.RouteName += routeslist.Where(x => x.RouteNo == newstop.ToString()).FirstOrDefault().RouteName +", ";
                            }


                        }
                        else
                        {
                            busStop.RouteName = routeslist.Where(x => x.RouteNo == busStop.RouteNo).FirstOrDefault().RouteName;
                        }
                    }
                    return View(bs.ListBusStop);
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
        public ActionResult Route(string Id)
        {
            Route route = db.Routes.Where(x => x.RouteNo == Id).FirstOrDefault();
            List<BusStop> busstops = db.BusStop.Where(x => x.RouteNo == route.RouteNo).ToList();
            RoutesViewModel routesViewModel = new RoutesViewModel();
            routesViewModel.Route = route;
            routesViewModel.BusStops = busstops;
            List<string> NewBusStops = new List<string>();
            var bslist = busstops.Select(x => x.BusNo);
            foreach (var item in bslist)
            {
                if(item.Contains(",") == true)
                {
                    var newitem =  item.Split(',');
                    NewBusStops.AddRange(newitem);
                }
                else
                {
                    NewBusStops.Add(item);
                }
            }
            routesViewModel.BusNosList = NewBusStops.OrderBy(x=>x).Distinct().ToList();
            return View(routesViewModel);
            
        }

    }
}