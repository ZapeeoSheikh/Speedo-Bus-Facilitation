using Speedo_Bus_Facilitation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Speedo_Bus_Facilitation.ViewModels
{
    public class RoutesViewModel
    {
        public Route Route { get; set; }
        public List<BusStop> BusStops { get; set; }
        public List<string> BusNosList { get; set; }
    }
}