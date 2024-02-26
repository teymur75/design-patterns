using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Real
{
    public class PaymentService
    { 
        private IPaymentService paymentService;

        public PaymentService()
        {
            
        }
        public PaymentService(IPaymentService paymentService)
        {
           this.paymentService = paymentService;
        }

        public void SetPAyment(IPaymentService PaymentService)
        {
            this.paymentService = PaymentService;
        }

        public bool PayViaStrategy(PaymentInfo PaymentInfo)
        {
            return paymentService.Pay(PaymentInfo);
        }
    }
}
