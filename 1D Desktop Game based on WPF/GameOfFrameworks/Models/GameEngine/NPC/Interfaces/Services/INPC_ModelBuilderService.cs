using GameEngine.NPC.Specializations;
using GameEngine.Player;

namespace GameEngine.NPC.Interfaces.Services
{
    public interface INPC_ModelBuilderService
    {
        int PlayerLevelScalingValue { get; }
        NPC_TYPE NPC_Type { get; }
        NPC_NAME Name { get; }
        NPC_ModelData Build();
    }
}
