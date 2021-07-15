using GameEngine.CombatEngine.Interfaces.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Player.ConditionResources
{
    public class DefensePower : IDefenseResourceType
    {
        public double IncomingDamageDivider { get; set; }
        public ResourceName Name { get; private set; } = ResourceName.DefensePower;
        public DefensePower()
        {
            IncomingDamageDivider = 1.0;
        }
    }
}
