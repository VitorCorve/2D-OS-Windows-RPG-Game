using GameEngine.NPC.Interfaces;
using GameEngine.NPC.Specializations.Animals;
using GameEngine.NPC.Specializations.Dragons;
using GameEngine.NPC.Specializations.Humans;
using GameEngine.NPC.Specializations.Undead;
using GameEngine.NPC.Specializations.Werewolfs;
using GameEngine.NPC.Interfaces.Instruments;
using System.Collections.Generic;

namespace GameEngine.NPC.Instruments
{
    public class CreateExpertNPCsList : ICreateNPCList
    {
        public List<INPC_Enemy> NPCList { get; set; } = new();
        public List<INPC_Enemy> CreateList()
        {
            NPCList.Add(new EntityModel_Bear());
            NPCList.Add(new EntityModel_Lindworm());
            NPCList.Add(new EntityModel_Moonwalker());
            NPCList.Add(new EntityModel_Mercenary());
            NPCList.Add(new EntityModel_UndeadSorcerer());

            return NPCList;
        }
    }
}
