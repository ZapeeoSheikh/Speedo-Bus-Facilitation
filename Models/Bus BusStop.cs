using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Speedo_Bus_Facilitation.Models
{
    public class Bus_BusStop
    {
        public int Id { get; set; }
        //public virtual Bus_Route BusRoute { get; set; }
        //public int busRouteId { get; set; }
        public virtual BusStop BusStop { get; set; }
        public int busStopId { get; set; }

    }
}