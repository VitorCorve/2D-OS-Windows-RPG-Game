using GameEngine.NPC.Interfaces;
using GameEngine.NPC.Specializations.Animals;
using GameEngine.NPC.Specializations.Dragons;
using GameEngine.NPC.Specializations.Humans;
using GameEngine.NPC.Specializations.Vampires;
using GameEngine.NPC.Specializations.Werewolfs;
using GameEngine.NPC.Interfaces.Instruments;
using System.Collections.Generic;

namespace GameEngine.NPC.Instruments
{
    public class CreateAdeptNPCsList : ICreateNPCList
    {
        public List<INPC_Enemy> NPCList { get; set; } = new();
        public List<INPC_Enemy> CreateList()
        {
            NPCList.Add(new EntityModel_Amphiptere());
            NPCList.Add(new EntityModel_Knucker());
            NPCList.Add(new EntityModel_Boar());
            NPCList.Add(new EntityModel_Servant());
            NPCList.Add(new EntityModel_Moonwalker());
            NPCList.Add(new EntityModel_Scavenger());

            return NPCList;
        }
    }
}
