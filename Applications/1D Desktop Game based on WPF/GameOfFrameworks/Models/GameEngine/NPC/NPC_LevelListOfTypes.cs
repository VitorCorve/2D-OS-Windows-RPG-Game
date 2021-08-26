using GameEngine.NPC.Interfaces;
using GameEngine.NPC.Specializations.Animals;
using GameEngine.NPC.Specializations.Dragons;
using GameEngine.NPC.Specializations.Humans;
using GameEngine.NPC.Specializations.Vampires;
using GameEngine.NPC.Specializations.Werewolfs;
using GameEngine.NPC.Specializations.Undead;
using System.Collections.Generic;
using GameEngine.Player;
using GameOfFrameworks.Models.GameEngine.NPC.Instruments;
using GameOfFrameworks.Models.GameEngine.NPC.Interfaces.Instruments;

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
                    return;
                case PLAYER_GRADE.Advanced:
                    NPCListCreator = new CreateAdvancedNPCsList();
                    return;
                case PLAYER_GRADE.Adept:
                    NPCListCreator = new CreateAdeptNPCsList();
                    return;
                case PLAYER_GRADE.Expert:
                    NPCListCreator = new CreateExpertNPCsList();
                    return;
                case PLAYER_GRADE.Master:
                    NPCListCreator = new CreateMasterNPCsList();
                    return;
                case PLAYER_GRADE.Legend:
                    NPCListCreator = new CreateLegendNPCsList();
                    return;
                default:
                    break;
            }
            NPCList = NPCListCreator.CreateList();
        }
    }
}
