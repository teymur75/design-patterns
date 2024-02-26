using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class TestObserver : IObserver
    {
        public  string FullName { get; set; }

        public TestObserver(string fullName)
        {
            FullName = fullName ?? throw new ArgumentNullException(fullName);
        }

        public void StockUpdate(Product product)
        {
            Console.WriteLine($"{FullName} product {product.Name} is in stock now ");
        }
    }
}
