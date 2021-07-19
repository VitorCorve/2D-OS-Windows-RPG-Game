using GameEngine.NPC.Interfaces;
using GameEngine.NPC.Interfaces.Services;
using GameEngine.NPC.Interfaces.SpecializationArchetypes;
using GameEngine.NPC.Specializations.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.NPC.Services
{
    public class NPC_Builder : INPC_Builder
    {
        public INPC_Enemy Build(INPC_Enemy npcArchetype)
        {
            switch (npcArchetype)
            {
                case IAnimal:
                    return new EntityModel_Bear();
                case IDragon:
                    return new EntityModel_Bear();
                default:
                    return npcArchetype;
            }
        }
    }
}
