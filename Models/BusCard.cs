using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Speedo_Bus_Facilitation.Models
{
    public class BusCard
    {
        public int Id { get; set; }
        public int CardNo { get; set; }
        public int CurrentBalance { get; set; }
        public int PrevBalance { get; set; }
        public int Limit { get; set; }
        public DateTime ShownTime { get; set; }
        public virtual Balance balance { get; set; }
        public int balanceId { get; set; }
    }
}