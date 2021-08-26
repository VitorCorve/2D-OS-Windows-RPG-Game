using GameEngine.CombatEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Player.ConditionResources
{
    public class Armor : IArmorResourceType
    {
        private int _value;
        public int Value
        {
            get { return _value; }
            set { _value = ValidateValue(value); }
        }
        public RESOURCE_NAME Name { get; private set; } = RESOURCE_NAME.Armor;
        public Armor(int value)
        {
            Value = value;
        }
        public Armor()
        {
        }

        private int ValidateValue(int value)
        {
            if (value < 0)
                return 0;
            else
                return value;
        }
    }
}
