﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Client : People
    {
        public Decimal Income { get; set; }
        public string Document { get; set; }
    }
}