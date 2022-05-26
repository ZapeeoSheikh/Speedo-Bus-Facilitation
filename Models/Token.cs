﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Speedo_Bus_Facilitation.Models
{
    public class Token
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime ValidTime { get; set; }
        public int Price { get; set; }
    }
}