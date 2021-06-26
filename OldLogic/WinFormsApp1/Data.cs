using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public static class Data
    {
        public static object NPC { get; set; }
        public static object Player { get; set; }
        public static int AttackCooldown { get; set; }
        public static int NPCAttackCooldown { get; set; }

        public static bool PlayerIsAlive;

        public static bool NPCIsAlive;

        public static object BattleWindowForm { get; set; }


        public static void SetPlayer(Player player)
        {
            Player = player;
        }

        public static object GetPlayer()
        {
            return Player;
        }

        public static void SetNPC(NPC npc)
        {
            NPC = npc;
        }

        public static object GetNPC()
        {
            return NPC;
        }
    }
}
