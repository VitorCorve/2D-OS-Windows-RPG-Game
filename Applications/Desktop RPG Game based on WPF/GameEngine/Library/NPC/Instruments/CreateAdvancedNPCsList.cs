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
    public class CreateAdvancedNPCsList : ICreateNPCList
    {
        public List<INPC_Enemy> NPCList { get; set; } = new();
        public List<INPC_Enemy> CreateList()
        {
            NPCList.Add(new EntityModel_Wolf());
            NPCList.Add(new EntityModel_Thug());
            NPCList.Add(new EntityModel_AncientWarrior());
            NPCList.Add(new EntityModel_Werewolf());
            NPCList.Add(new EntityModel_Vampire());

            return NPCList;
        }
    }
}
