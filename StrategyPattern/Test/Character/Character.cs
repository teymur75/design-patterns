using StrategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Character
{
    public class Character
    {
        private ICombatStrategy _combatStrategy;

        public Character(ICombatStrategy combatStrategy)
        {
            _combatStrategy = combatStrategy;
        }
        public Character()
        {
            
        }

        public void SetCombat(ICombatStrategy combatStrategy)
        {
            this._combatStrategy = combatStrategy; 
        }

        public void ApplyAttactStrategy()
        {
            _combatStrategy.Attack();
        }
    }
}
