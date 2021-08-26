using GameEngine.NPC.Interfaces;
using GameEngine.NPC.Specializations.Animals;
using GameEngine.NPC.Specializations.Humans;
using GameEngine.NPC.Specializations.Undead;
using GameEngine.NPC.Specializations.Vampires;
using GameEngine.NPC.Specializations.Werewolfs;
using GameEngine.NPC.Interfaces.Instruments;
using System.Collections.Generic;

namespace GameEngine.NPC.Instruments
{
    public class CreateNoviceNPCsList : ICreateNPCList
    {
        public List<INPC_Enemy> NPCList { get; set; } = new();
        public List<INPC_Enemy> CreateList()
        {
            NPCList.Add(new EntityModel_Rat());
            NPCList.Add(new EntityModel_Bandit());
            NPCList.Add(new EntityModel_Skeleton());
            NPCList.Add(new EntityModel_Ghoul());
            NPCList.Add(new EntityModel_CursedTraveler());

            return NPCList;
        }
    }
}
