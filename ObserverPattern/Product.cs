﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Product
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public int Stock { get; set; }

        public Product(string name,string price)
        {
            Name = name;
            Price = price;
        }
    }
}
