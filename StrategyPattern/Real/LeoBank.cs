using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Real
{
    public class LeoBank : IPaymentService
    {
        public bool Pay(PaymentInfo paymentInfo)
        {
            Console.WriteLine("LeoBank  Odeme");
            return true;
        }
    }
}
