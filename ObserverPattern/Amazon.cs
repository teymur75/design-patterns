using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Amazon
    {
        private Dictionary<IObserver,Product> observers=new();

        public void REgister(IObserver observer,Product product)
        {
            observers.TryAdd(observer, product);
        }

        public void UNRegister(IObserver observer) 
        {
            observers.Remove(observer);
        }

        public void NOtifyAll()
        {
            foreach (var obs in observers)
            {
                obs.Key.StockUpdate(obs.Value);
            }
        }
    }
}
