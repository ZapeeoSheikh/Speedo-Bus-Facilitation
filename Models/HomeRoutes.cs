using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Speedo_Bus_Facilitation.Models
{
    public class HomeRoutes
    {
        public int Id { get; set; }
        public virtual BusStop busStop { get; set; }
        public int BsuStopId { get; set; }


    }
}