using GameEngine.Locations;
using GameEngine.NPC.Interfaces;
using GameEngine.NPC.Specializations;
using GameEngine.Player;

namespace GameEngine.NPC
{
    public class NPC_ModelData : INPC_ModelData
    {
        public NPC_NAME Name { get; private set; }
        public SPECIALIZATION Specialization { get; private set; }
        public int Level { get; private set; }
        public LAND CurrentLocation { get; private set; }
        public NPC_ModelData(NPC_NAME name, SPECIALIZATION specialization, int level)
        {
            Name = name;
            Specialization = specialization;
            Level = level;
        }
    }
}
