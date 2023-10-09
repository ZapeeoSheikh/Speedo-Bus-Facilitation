using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Speedo_Bus_Facilitation.Models
{
    public class Depot
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int NoOfBus { get; set; }
        public int NoServiceBus { get; set; }
        public virtual Bus bus { get; set; }
        public int busId { get; set; }

    }
}