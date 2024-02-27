using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern_
{
    public class Shipping : IOrderHandler
    {
        private IOrderHandler next;

        public void SetNext(IOrderHandler next)
        {
            this.next = next;
        }
        public bool HAndle(Order order)
        {
            bool isShipping = true;
            if (isShipping && next is not null)
            {
                return next.HAndle(order);
            }

            return false;
        }

       
    }
}
