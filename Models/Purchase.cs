﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public Car Car { get; set; }
        public Decimal Price { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}