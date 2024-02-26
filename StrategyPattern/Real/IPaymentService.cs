using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Real
{
    public interface IPaymentService
    {
        bool Pay(PaymentInfo paymentInfo);
    }
}
