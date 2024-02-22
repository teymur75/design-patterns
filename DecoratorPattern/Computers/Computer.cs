using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Computers
{
    public class Computer
    {
        public void Start()
        {
            Console.WriteLine($"{GetType().Name} is starting");
        }

        public void ShutDown()
        {
            Console.WriteLine($"{GetType().Name} is shuttingDown");
        }
    }

    public class Laptop:Computer
    {
        public void OpenLid()
        {
            Console.WriteLine($"{GetType().Name}'s lid is opening");
        }

        public void CloseLid()
        {
            Console.WriteLine($"{GetType().Name} 's lid is closing");
        }
    }

    public class LaptopDecorator:Laptop
    {
        public virtual void OpenLid()
        {
            //do something
            base.OpenLid();
        }

        public virtual void CloseLid()
        {
            //do something
            base.CloseLid();
        }
    }

    public class DellLaptop:LaptopDecorator
    {
        public override void CloseLid()
        {
            base.CloseLid();
            Console.WriteLine("Dell Laptop is sleeping");
        }

        public override void OpenLid()
        {
            base.OpenLid();
            Console.WriteLine("DEll laptop is waking");
        }
    }

    public class AppleLaptop : LaptopDecorator
    {
        public void OpenLid()
        {
            //do something
            base.OpenLid();
        }

        public void CloseLid()
        {
            //do something
            base.CloseLid();
        }
    }
}
