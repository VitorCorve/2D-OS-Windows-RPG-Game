using GameEngine.CombatEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Player.ConditionResources
{
    public class Energy : IResourceType
    {
        public uint Value { get; set; }
        public Energy(uint value)
        {
            Value = value;
        }
        public Energy()
        {

        }
    }
}
