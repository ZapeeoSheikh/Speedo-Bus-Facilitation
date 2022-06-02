using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Speedo_Bus_Facilitation.Models
{
    public class Bus
    {
        public int Id { get; set; }
        public int No { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public int TotalStops { get; set; }

    }
}