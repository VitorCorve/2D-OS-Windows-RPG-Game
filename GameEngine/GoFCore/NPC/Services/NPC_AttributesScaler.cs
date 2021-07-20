using GameEngine.NPC.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.NPC.Services
{
    public class NPC_AttributesScaler : IAttributesScaler
    {
        public void Scale(INPC_Enemy npc, int level)
        {
            npc.Strength += level;
            npc.Stamina += level;
            npc.Intellect += level;
            npc.Agility += level;
            npc.Endurance += level;
            npc.WeaponDamageValue += level;
            npc.ArmorValue += level;
        }
    }
}
