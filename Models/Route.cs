using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Speedo_Bus_Facilitation.Models
{
    public class Route
    {
        public int Id { get; set; }
        public int Distance { get; set; }
        public virtual Line line { get; set; }
        public int lineId { get; set; }
        public virtual Stop stop { get; set; }
        public int stopId { get; set; }
    }
}