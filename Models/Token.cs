using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Speedo_Bus_Facilitation.Models
{
    public class Token
    {
        [Key]
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime ValidTime { get; set; }
        public int Price { get; set; }
    }
}