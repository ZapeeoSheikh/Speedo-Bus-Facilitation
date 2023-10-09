using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Speedo_Bus_Facilitation.Models
{
    public class HomeRoutes
    {
        [Key]
        public int Id { get; set; }
        public virtual BusStop busStop { get; set; }
        public int BsuStopId { get; set; }


    }
}