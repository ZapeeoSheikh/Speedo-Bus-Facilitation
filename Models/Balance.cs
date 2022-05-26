using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Speedo_Bus_Facilitation.Models
{
    public class Balance
    {
        public int Id { get; set; }
        public virtual BusCard card { get; set; }
        public int cardId { get; set; }
        public int BalanceHistory { get; set; }
    }
}