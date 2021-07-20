using GameEngine.NPC.Interfaces;
using GameEngine.NPC.Interfaces.Managers;
using GameEngine.Player.Abstract;
using GameEngine.Player;
using System.Collections.Generic;

namespace GameEngine.NPC
{
    public class NPC_CreationManager : INPC_CreationManager
    {
        public PlayerModelData NPC_Model { get; private set; }
        public IEntityAttributes NPC { get; private set; }
        public NPC_CreationManager(PlayerModelData playerModelData)
        {
            var npcList = new NPC_LevelListOfTypes(playerModelData.PlayerGrade);

            switch (playerModelData.PlayerGrade)
            {
                case PLAYER_GRADE.Novice:
                    Create(npcList.Novice, playerModelData.Level);
                    return;
                case PLAYER_GRADE.Advanced:
                    Create(npcList.Advanced, playerModelData.Level);
                    return;
                case PLAYER_GRADE.Adept:
                    Create(npcList.Adept, playerModelData.Level);
                    return;
                case PLAYER_GRADE.Expert:
                    Create(npcList.Expert, playerModelData.Level);
                    return;
                case PLAYER_GRADE.Master:
                    Create(npcList.Master, playerModelData.Level);
                    return;
                case PLAYER_GRADE.Legend:
                    Create(npcList.Legend, playerModelData.Level);
                    return;
                default:
                    break;
            }
        }
        public void Create(List<INPC_Enemy> npcList, int level)
        {
            var npcBuilderService = new NPC_BuilderService(npcList, level);
            NPC = npcBuilderService.Build();
        }
    }
}
