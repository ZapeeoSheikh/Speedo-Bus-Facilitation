using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Speedo_Bus_Facilitation.Models
{
    public class Passenger
    {
        [Key]
        public int Id { get; set; }
        public virtual BusCard busCard { get; set; }
        public int busCardId { get; set; }

    }
}