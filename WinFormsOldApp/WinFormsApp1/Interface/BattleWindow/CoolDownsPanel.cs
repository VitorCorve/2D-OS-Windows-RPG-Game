using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WinFormsApp1.Interface.BattleWindow
{
    public static class CoolDownsPanel
    {
        public static bool BackStabReady { get; set; }

        public static Timer GlobalCoolDown { get; set; }

        public static int GlobalCoolDownStage { get; set; }

        public static bool GlobalCooldownActive { get; set; }

        public static void View(string skill)
        {
            if (skill == "Backstab")
            {
                BackStabReady = false;
            }
        }
    }
}
