using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern_
{
    public class StockControl : IOrderHandler
    {
        private IOrderHandler next;

        public void SetNext(IOrderHandler next)
        {
            this.next = next;
        }
        public bool HAndle(Order order)
        {
            bool stockAvailable = true;
            if (next is not null && stockAvailable)
            {
                return next.HAndle(order);
            }

            return false;
        }

       
    }
}
