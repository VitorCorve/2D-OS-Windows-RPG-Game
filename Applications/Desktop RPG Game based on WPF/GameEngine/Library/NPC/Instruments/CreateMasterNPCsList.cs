using GameEngine.NPC.Interfaces;
using GameEngine.NPC.Specializations.Dragons;
using GameEngine.NPC.Specializations.Humans;
using GameEngine.NPC.Specializations.Undead;
using GameEngine.NPC.Specializations.Vampires;
using GameEngine.NPC.Specializations.Werewolfs;
using GameEngine.NPC.Interfaces.Instruments;
using System.Collections.Generic;

namespace GameEngine.NPC.Instruments
{
    public class CreateMasterNPCsList : ICreateNPCList
    {
        public List<INPC_Enemy> NPCList { get; set; } = new();
        public List<INPC_Enemy> CreateList()
        {
            NPCList.Add(new EntityModel_Wyvern());
            NPCList.Add(new EntityModel_Assassin());
            NPCList.Add(new EntityModel_Inquisitor());
            NPCList.Add(new EntityModel_Nosferatu());
            NPCList.Add(new EntityModel_Heartbraker());

            return NPCList;
        }
    }
}
