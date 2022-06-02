using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Speedo_Bus_Facilitation.Models
{
    public class Line
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CurrentStop { get; set; }
        public string NextStop { get; set; }
        public string PrevStop { get; set; }


    }
}