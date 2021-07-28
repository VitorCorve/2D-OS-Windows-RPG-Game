using GameEngine.Locations;
using GameEngine.NPC.Specializations;
using GameEngine.Player;

namespace GameEngine.NPC.Interfaces
{
    public interface INPC_ModelData
    {
        NPC_NAME Name { get; }
        SPECIALIZATION Specialization { get; }
        int Level { get; }
        LAND CurrentLocation { get; }
    }
}
