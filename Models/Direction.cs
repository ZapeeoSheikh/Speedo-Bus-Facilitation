using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Speedo_Bus_Facilitation.Models
{
    public class Direction
    {
        public int Id { get; set; }
        public virtual Route route { get; set; }
        public int routeId { get; set; }
    }
}