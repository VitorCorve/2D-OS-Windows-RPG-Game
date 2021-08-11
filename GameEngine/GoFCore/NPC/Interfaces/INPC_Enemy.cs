using GameEngine.NPC.Specializations;
using GameEngine.Player;
using GameEngine.Player.Abstract;

namespace GameEngine.NPC.Interfaces
{
    public interface INPC_Enemy : IEntityAttributes
    {
        NPC_TYPE NPC_Type { get; }
        NPC_NAME Name { get; }
    }
}
