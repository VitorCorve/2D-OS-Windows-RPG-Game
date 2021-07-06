using GameEngine.CombatEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Player.ConditionResources
{
    public class Armor : IValueType
    {
        public uint Value { get; set; }
        public Armor(uint value)
        {
            Value = value;
        }
        public Armor()
        {

        }
    }
}
