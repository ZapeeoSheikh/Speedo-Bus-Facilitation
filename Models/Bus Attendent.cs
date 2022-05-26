using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Speedo_Bus_Facilitation.Models
{
    public class Bus_Attendent
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public virtual Bus_Card { get; set; }
    public int Bus_CardId { get; set; }
    public int BusNo { get; set; }

}
}