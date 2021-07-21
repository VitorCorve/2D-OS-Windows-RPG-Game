using GameEngine.Player.Abstract;
using System.Collections.Generic;


namespace GameEngine.NPC.Interfaces.Services
{
    public interface INPC_BuilderService
    {
        int PlayerLevelScalingValue { get; }
        List<INPC_Enemy> NPC_List { get; }
        INPC_Enemy Build();
    }
}
