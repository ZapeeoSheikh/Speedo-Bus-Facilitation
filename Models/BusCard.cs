using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Speedo_Bus_Facilitation.Models
{
    public class BusCard
    {
        [Key]
        public int Id { get; set; }
        public int CardNo { get; set; }
        public int Limit { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }
}