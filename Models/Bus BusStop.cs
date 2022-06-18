using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Speedo_Bus_Facilitation.Models
{
    public class Bus_BusStop
    {
        public int Id { get; set; }
        public virtual Bus bus { get; set; }
        public int busId { get; set; }
        public virtual BusStop BusStop { get; set; }
        public int busStopId { get; set; }
        //public virtual Route Route { get; set; }
        //public int RouteId { get; set; }
    }
}