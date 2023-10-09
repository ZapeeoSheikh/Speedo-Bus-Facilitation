using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Speedo_Bus_Facilitation.Models
{
    public class Route
    {
        [Key]
        public string Name { get; set; }
        //public int Id { get; set; }
        public int Distance { get; set; }
        
        //public int Number { get; set; }

    }
}