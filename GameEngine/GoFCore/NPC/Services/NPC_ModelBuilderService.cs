using GameEngine.NPC.Interfaces;
using GameEngine.NPC.Interfaces.Services;
using GameEngine.NPC.Specializations;
using GameEngine.Player;

namespace GameEngine.NPC.Services
{
    public class NPC_ModelBuilderService : INPC_ModelBuilderService
    {
        public int PlayerLevelScalingValue { get; private set; }
        public SPECIALIZATION Specialization { get; private set; }
        public NPC_NAME Name { get; set; }
        public NPC_ModelBuilderService(INPC_Enemy enemyType, int level)
        {
            PlayerLevelScalingValue = level;
            Specialization = enemyType.Specialization;
            Name = enemyType.Name;
        }
        public NPC_ModelData Build()
        {
            var playerModel = new NPC_ModelData(Name, Specialization, PlayerLevelScalingValue);
            return playerModel;
        }
    }
}
