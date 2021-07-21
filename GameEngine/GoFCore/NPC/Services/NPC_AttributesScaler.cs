using GameEngine.NPC.Interfaces;
using GameEngine.NPC.Interfaces.Services;

namespace GameEngine.NPC.Services
{
    public class NPC_AttributesScaler : INPC_AttributesScaler
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
