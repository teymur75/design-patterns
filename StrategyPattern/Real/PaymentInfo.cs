﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Real
{
    public class PaymentInfo
    {
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public string ExpirationDate { get; set; }
        public string CVV { get; set; }
        public decimal Amount { get; set; }
    }
}
