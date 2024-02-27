using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern_
{
    public interface IOrderHandler
    {
        void SetNext(IOrderHandler next);
        bool HAndle(Order order);
    }
}
