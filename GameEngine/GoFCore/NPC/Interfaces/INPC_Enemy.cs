using GameEngine.NPC.Specializations;
using GameEngine.Player;
using GameEngine.Player.Abstract;

namespace GameEngine.NPC.Interfaces
{
    public interface INPC_Enemy : IEntityAttributes
    {
        SPECIALIZATION Specialization { get; }
        NPC_NAME Name { get; }
    }
}
