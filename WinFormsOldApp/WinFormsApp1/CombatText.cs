using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public static class CombatText
    {
        public static bool Accepted {get; set; }
        public static bool DefenseAccepted {get; set; }
        public static bool NPCDefenseAccepted {get; set; }
        public static bool NPCAccepted {get; set; }
        public static string Text { get; set; }
        public static string PlayerDamage { get; set; }
        public static string NPCDamage { get; set; }

        public static string CombatEvent { get; set; }

        public static string Actor { get; set; }

        public static List<string> CombatData { get; set; }
        public static List<string> CombatDefenseData { get; set; }
        public static List<string> NPCCombatDefenseData { get; set; }
        public static List<string> CombatDataNPC { get; set; }


    }
}
