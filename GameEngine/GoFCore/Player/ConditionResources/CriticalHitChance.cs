using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Interfaces.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Player.ConditionResources
{
    public class CriticalHitChance : ICriticalHitResourceType
    {
        private double _value;
        public double Value
        {
            get { return _value; }
            set { _value = ValidateValue(value); }
        }

        public RESOURCE_NAME Name { get; private set; } = RESOURCE_NAME.CriticalHitChance;
        public CriticalHitChance(double value)
        {
            Value = value;
        }
        public CriticalHitChance()
        {

        }

        private double ValidateValue(double value)
        {
            if (value < 0)
                return 0;
            if (value  > 100)
                return 100;
            else
                return value;
        }
    }
}
