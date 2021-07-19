using GameEngine.CombatEngine;
using GameEngine.Player;

namespace GameEngine.NPC.Interfaces.Services
{
    public interface INPC_CreationManager
    {
        PlayerEntity NPC { get; }
        PlayerModelData NPC_ModelData { get; }
    }
}
