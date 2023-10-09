using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Speedo_Bus_Facilitation.Models
{
    public class BusAttendent
    {
        [Key]
        public int Id { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public virtual BusCard card { get; set; }
        public int cardId { get; set; }
        public virtual Bus bus { get; set; }
        public int busId { get; set; }
        public virtual Role role { get; set; }
        public int roleId { get; set; }

    }
}