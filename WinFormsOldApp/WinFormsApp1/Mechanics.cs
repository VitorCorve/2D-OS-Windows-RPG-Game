using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public static class Combat
    {
        public static bool InCombat { get; set; }
    }
    interface Mechanics
    {
        void Hit(NPC npc);

        void Hit(Player player);
        void Heal(NPC npc);
        void Heal(Player player);

        void Recover();

        bool Dodge();

        bool Block();

        bool Alive();

    }
}

