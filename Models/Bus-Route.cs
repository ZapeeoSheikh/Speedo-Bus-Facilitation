using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Speedo_Bus_Facilitation.Models
{
    public class Bus_Route
    {
        public int Id { get; set; }
        public virtual Bus bus { get; set; }
        public int busId { get; set; }
        public virtual Route route { get; set; }
        public int routeId { get; set; }
    }
}

//not commited