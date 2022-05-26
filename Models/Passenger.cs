using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Speedo_Bus_Facilitation.Models
{
    public class Passenger
    {
        public int Id { get; set; }
        public virtual BusCard busCard { get; set; }
        public int busCardId { get; set; }

    }
}