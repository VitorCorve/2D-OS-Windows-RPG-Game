using GameEngine.NPC.Interfaces;
using GameEngine.NPC.Interfaces.Services;
using GameEngine.NPC.Services;
using GameEngine.Player.Abstract;
using System;
using System.Collections.Generic;

namespace GameEngine.NPC.Services
{
    public class NPC_BuilderService : INPC_BuilderService
    {
        public int PlayerLevelScalingValue { get; private set; }
        public List<INPC_Enemy> NPC_List { get; private set; } = new ();
        public NPC_BuilderService(List<INPC_Enemy> npcList, int level)
        {
            PlayerLevelScalingValue = level;
            NPC_List = npcList;
        }

        public INPC_Enemy Build()
        {
            var npcAttributesScaler = new NPC_AttributesScaler();

            Random randomChoice = new Random();
            int random = randomChoice.Next(0, NPC_List.Count);
            int count = 0;

            foreach (var npc in NPC_List)
            {
                if (count == random)
                {
                    npcAttributesScaler.Scale(npc, PlayerLevelScalingValue);
                    return npc;
                }
                count++;
            }
            return null;
        }
    }
}
