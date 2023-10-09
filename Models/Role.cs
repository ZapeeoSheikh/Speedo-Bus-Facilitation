using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Speedo_Bus_Facilitation.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public int Title { get; set; }
    }
}