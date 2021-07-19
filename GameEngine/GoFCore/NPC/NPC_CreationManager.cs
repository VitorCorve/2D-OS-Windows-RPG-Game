using GameEngine.CombatEngine;
using GameEngine.NPC.Interfaces.Services;
using GameEngine.Player;

namespace GameEngine.NPC
{
    public class NPC_CreationManager : INPC_CreationManager
    {
        // This managers targets to create scallable npc enemy for player, which level and power bases on player's level
        public PlayerEntity NPC { get; private set; }
        public PlayerModelData NPC_ModelData { get; private set; }
        public NPC_CreationManager(PlayerModelData playerModelData)
        {

        }
    }
}
