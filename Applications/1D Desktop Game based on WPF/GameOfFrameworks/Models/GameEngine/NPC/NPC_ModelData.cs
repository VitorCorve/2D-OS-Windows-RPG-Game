using GameEngine.Locations;
using GameEngine.NPC.Interfaces;
using GameEngine.NPC.Specializations;
using GameEngine.Player;

namespace GameEngine.NPC
{
    public class NPC_ModelData : INPC_ModelData
    {
        public NPC_NAME Name { get; private set; }
        public NPC_TYPE NPC_Type { get; private set; }
        public int Level { get; private set; }
        public LAND CurrentLocation { get; private set; }
        public NPC_ModelData(NPC_NAME name, NPC_TYPE npcType, int level)
        {
            Name = name;
            NPC_Type = npcType;
            Level = level;
        }
    }
}
