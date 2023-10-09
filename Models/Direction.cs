using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Speedo_Bus_Facilitation.Models
{
    public class Direction
    {
        [Key]
        public int Id { get; set; }
        public virtual Route route { get; set; }
        public int routeId { get; set; }
    }
}