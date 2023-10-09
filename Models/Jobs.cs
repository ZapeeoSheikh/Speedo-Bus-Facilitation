using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Speedo_Bus_Facilitation.Models
{
    public class Jobs
    {
        [Key]
        public int Id { get; set; }
        public string Post { get; set; }
        public string Location { get; set; }
        public string Department { get; set; }

    }
}