﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Employee : People
    {
        public Position Position { get; set; }
        public Decimal CommissionValue { get; set; }
        public Decimal Commission { get; set; }
    }
}
