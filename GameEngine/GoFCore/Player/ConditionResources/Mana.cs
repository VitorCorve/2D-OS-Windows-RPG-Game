using GameEngine.CombatEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Player.ConditionResources
{
    public class Mana : IConditionResourceType
    {
        private int _value;
        public int Value
        {
            get { return _value; }
            set { _value = ValidateValue(value); }
        }
        public int MaxValue { get; private set; }
        public ResourceName Name { get; private set; } = ResourceName.Mana;
        public Mana(int value)
        {
            MaxValue = value;
            Value = value;
        }
        public Mana()
        {

        }

        private int ValidateValue(int value)
        {
            if (value < 0)
                return 0;

            if (value > MaxValue)
                return MaxValue;

            else
                return value;
        }
    }
}
