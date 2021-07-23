using GameEngine.NPC.Interfaces;
using GameEngine.NPC.Specializations.Animals;
using GameEngine.NPC.Specializations.Dragons;
using GameEngine.NPC.Specializations.Humans;
using GameEngine.NPC.Specializations.Vampires;
using GameEngine.NPC.Specializations.Werewolfs;
using GameEngine.NPC.Specializations.Undead;
using System.Collections.Generic;
using GameEngine.Player;

namespace GameEngine.NPC
{
    public class NPC_LevelListOfTypes
    {
        public List<INPC_Enemy> Novice = new List<INPC_Enemy> { };
        public List<INPC_Enemy> Advanced = new List<INPC_Enemy> { };
        public List<INPC_Enemy> Adept = new List<INPC_Enemy> { };
        public List<INPC_Enemy> Expert = new List<INPC_Enemy> { };
        public List<INPC_Enemy> Master = new List<INPC_Enemy> { };
        public List<INPC_Enemy> Legend = new List<INPC_Enemy> { };

        public NPC_LevelListOfTypes(PLAYER_GRADE grade)
        {
            switch (grade)
            {
                case PLAYER_GRADE.Novice:
                    CreateNoviceNPCs();
                    return;
                case PLAYER_GRADE.Advanced:
                    CreateAdvancedNPCs();
                    return;
                case PLAYER_GRADE.Adept:
                    CreateAdeptNPCs();
                    return;
                case PLAYER_GRADE.Expert:
                    CreateExpertNPCs();
                    return;
                case PLAYER_GRADE.Master:
                    CreateMasterNPCs();
                    return;
                case PLAYER_GRADE.Legend:
                    CreateLegendNPCs();
                    return;
                default:
                    break;
            }
        }
        private void CreateNoviceNPCs()
        {
            Novice.Add(new EntityModel_Rat());
            Novice.Add(new EntityModel_Bandit());
            Novice.Add(new EntityModel_Skeleton());
            Novice.Add(new EntityModel_Ghoul());
            Novice.Add(new EntityModel_CursedTraveler());
        }
        private void CreateAdvancedNPCs()
        {
            Advanced.Add(new EntityModel_Wolf());
            Advanced.Add(new EntityModel_Thug());
            Advanced.Add(new EntityModel_AncientWarrior());
            Advanced.Add(new EntityModel_Werewolf());
            Advanced.Add(new EntityModel_Vampire());
        }
        private void CreateAdeptNPCs()
        {
            Adept.Add(new EntityModel_Amphiptere());
            Adept.Add(new EntityModel_Knucker());
            Adept.Add(new EntityModel_Boar());
            Adept.Add(new EntityModel_Servant());
            Adept.Add(new EntityModel_Moonwalker());
            Adept.Add(new EntityModel_Scavenger());
        }
        private void CreateExpertNPCs()
        {
            Expert.Add(new EntityModel_Bear());
            Expert.Add(new EntityModel_Lindworm());
            Expert.Add(new EntityModel_Moonwalker());
            Expert.Add(new EntityModel_Mercenary());
            Expert.Add(new EntityModel_UndeadSorcerer());
        }
        private void CreateMasterNPCs()
        {
            Master.Add(new EntityModel_Wyvern());
            Master.Add(new EntityModel_Assassin());
            Master.Add(new EntityModel_Inquisitor());
            Master.Add(new EntityModel_Nosferatu());
            Master.Add(new EntityModel_Heartbraker());
        }
        private void CreateLegendNPCs()
        {
            Legend.Add(new EntityModel_Necrolord());
            Legend.Add(new EntityModel_Nightlord());
            Legend.Add(new EntityModel_Nightmare());
            Legend.Add(new EntityModel_Earthreaper());
        }
    }
}
