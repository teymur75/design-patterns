﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class TransferTransaction
    {
        public string FromIban { get; set; }
        public string ToIban { get; set; }
        public decimal Amount { get; set; }

    }
}
