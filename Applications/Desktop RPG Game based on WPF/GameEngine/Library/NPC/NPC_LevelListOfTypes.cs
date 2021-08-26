using GameEngine.NPC.Interfaces;
using System.Collections.Generic;
using GameEngine.Player;
using GameEngine.NPC.Instruments;
using GameEngine.NPC.Interfaces.Instruments;

namespace GameEngine.NPC
{
    public class NPC_LevelListOfTypes
    {
        public List<INPC_Enemy> NPCList { get; set; } = new();
        public ICreateNPCList NPCListCreator { get; set; }
        public NPC_LevelListOfTypes(PLAYER_GRADE grade)
        {
            switch (grade)
            {
                case PLAYER_GRADE.Novice:
                    NPCListCreator = new CreateNoviceNPCsList();
                    break;
                case PLAYER_GRADE.Advanced:
                    NPCListCreator = new CreateAdvancedNPCsList();
                    break;
                case PLAYER_GRADE.Adept:
                    NPCListCreator = new CreateAdeptNPCsList();
                    break;
                case PLAYER_GRADE.Expert:
                    NPCListCreator = new CreateExpertNPCsList();
                    break;
                case PLAYER_GRADE.Master:
                    NPCListCreator = new CreateMasterNPCsList();
                    break;
                case PLAYER_GRADE.Legend:
                    NPCListCreator = new CreateLegendNPCsList();
                    break;
                default:
                    break;
            }
            NPCList = NPCListCreator.CreateList();
        }
    }
}
