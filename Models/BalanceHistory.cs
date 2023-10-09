using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Speedo_Bus_Facilitation.Models
{
    public class BalanceHistory
    {
        [Key]
        public int Id { get; set; }
        public virtual BusCard card { get; set; }
        public int cardId { get; set; }
        public int History { get; set; }
    }
}