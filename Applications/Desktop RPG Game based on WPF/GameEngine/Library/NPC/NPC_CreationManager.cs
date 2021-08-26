using GameEngine.NPC.Interfaces;
using GameEngine.NPC.Interfaces.Managers;
using GameEngine.Player;
using System.Collections.Generic;
using GameEngine.NPC.Services;

namespace GameEngine.NPC
{
    public class NPC_CreationManager : INPC_CreationManager
    {
        public NPC_ModelData NPC_Model { get; private set; }
        public INPC_Enemy NPC { get; private set; }
        public NPC_CreationManager(PlayerModelData playerModelData)
        {
            var npcList = new NPC_LevelListOfTypes(playerModelData.PlayerGrade);

            Create(npcList.NPCList, playerModelData.Level);
        }
        private void Create(List<INPC_Enemy> npcList, int level)
        {
            var npcBuilderService = new NPC_BuilderService(npcList, level);
            NPC = npcBuilderService.Build();

            var npcModelBuilderService = new NPC_ModelBuilderService(NPC, level);
            NPC_Model = npcModelBuilderService.Build();
        }
    }
}
