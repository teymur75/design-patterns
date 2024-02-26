using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Real
{
    public class Abb : IPaymentService
    {
        public bool Pay(PaymentInfo paymentInfo)
        {
            Console.WriteLine("Abb Bank Odeme");
            return true;
        }
    }
}
