﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Speedo_Bus_Facilitation.Models
{
    public class BusStop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Bus bus { get; set; }
        //public int busId { get; set; }
        public virtual Route route { get; set; }
        //public int routeId { get; set; }
        //public virtual Bus_BusStop BusBusStop { get; set; }
        //public int BusBusStopId { get; set; }

    }
}