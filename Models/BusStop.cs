using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Speedo_Bus_Facilitation.Models
{
    public class BusStop
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Routes")]
        public string RouteNo { get; set; }
        public virtual Route Routes { get; set; }
        public string RouteName { get; set; }
        [NotMapped]
        public List<BusStop> ListBusStop { get; set; }

    }
}