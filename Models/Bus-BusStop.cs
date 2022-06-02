using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Speedo_Bus_Facilitation.Models
{
    public class Bus_BusStop
    {
        public int Id { get; set; }
        public virtual BusStop BusStop { get; set; }
        public int BusStopId { get; set; }
        public virtual Bus Bus { get; set; }
        public int BusId { get; set; }
        public virtual Route Route { get; set; }
        public int RouteId { get; set; }
    }
}