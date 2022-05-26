using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Speedo_Bus_Facilitation.Models
{
    public class Stop
    {
        public int Id { get; set; }
        public String Names { get; set; }
        public int StopNumber { get; set; }
        public int NumberOfStops { get; set; }
    }
}