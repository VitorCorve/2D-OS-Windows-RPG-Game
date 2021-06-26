using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public static class CalculateReward
    {
        public static int Reward;
        public static int Initialize(NPC npc)
        {
            Random randomize = new Random();
            int reward = npc.GetLevel() * 6;
            int result = reward * randomize.Next(7, 13) / 10;
            Reward = result;
            return result;
            
        }

    }
}
