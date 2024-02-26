using StrategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Attacks
{
    public class AggresiveCOmbatStrategy : ICombatStrategy
    {
        public void Attack()
        {
            Console.WriteLine("Agresive Attack");
        }
    }
}
