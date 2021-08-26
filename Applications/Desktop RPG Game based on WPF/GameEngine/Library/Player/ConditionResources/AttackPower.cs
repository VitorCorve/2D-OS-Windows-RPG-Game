using GameEngine.CombatEngine.Interfaces.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Player.ConditionResources
{
    public class AttackPower : IAttackPowerResourceType
    {
        public double OutcomingDamageMultiplier { get; set; }
        private int _value;
        public int Value
        {
            get { return ValidateValue(_value); }
            set { _value = value; }
        }
        public RESOURCE_NAME Name { get; private set; } = RESOURCE_NAME.AttackPower;
        public AttackPower(int value)
        {
            OutcomingDamageMultiplier = 1;
            Value = value;
        }
        public AttackPower()
        {
        }

        private int ValidateValue(int value)
        {
            if (value < 0)
                return 0;
            else
                return (int)(value * OutcomingDamageMultiplier);
        }
    }
}
