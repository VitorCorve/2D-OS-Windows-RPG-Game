using GameEngine.NPC.Interfaces;
using GameEngine.NPC.Specializations.Dragons;
using GameEngine.NPC.Specializations.Undead;
using GameEngine.NPC.Specializations.Vampires;
using GameEngine.NPC.Specializations.Werewolfs;
using GameEngine.NPC.Interfaces.Instruments;
using System.Collections.Generic;

namespace GameEngine.NPC.Instruments
{
    public class CreateLegendNPCsList : ICreateNPCList
    {
        public List<INPC_Enemy> NPCList { get; set; } = new();
        public List<INPC_Enemy> CreateList()
        {
            NPCList.Add(new EntityModel_Necrolord());
            NPCList.Add(new EntityModel_Nightlord());
            NPCList.Add(new EntityModel_Nightmare());
            NPCList.Add(new EntityModel_Earthreaper());

            return NPCList;
        }
    }
}
