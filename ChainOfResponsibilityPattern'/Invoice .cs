using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern_
{
    public class Invoice : IOrderHandler
    {
        private IOrderHandler next;

        public void SetNext(IOrderHandler next)
        {
            this.next = next;
        }
        public bool HAndle(Order order)
        {
            bool isOnvoice = true;
            if (isOnvoice && next is not null)
            {
                return next.HAndle(order);
            }

            return false;
        }

       
    }
}
