using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Interface.BattleWindow
{
    public static class ButtonsCache
    {
        public static SkillButton Button1 { get; set; }
        public static SkillButton Button2 { get; set; }
        public static SkillButton Button3 { get; set; }
        public static SkillButton Button4 { get; set; }
        public static SkillButton Button5 { get; set; }

        public static bool Button1Ready { get; set; }
        public static bool Button2Ready { get; set; }
        public static bool Button3Ready { get; set; }
        public static bool Button4Ready { get; set; }
        public static bool Button5Ready { get; set; }

        public static List<SkillButton> Buttons { get; set; } 


        public static void SetCoolDown(string name)
        {
            foreach (var skill in Buttons)
            {
                if (skill.SkillName == name)
                {
                    skill.Statement = skill.pressImg;
                }
            }
        }

        public static void CancelCoolDown(string name)
        {
            foreach (var skill in Buttons)
            {
                if (skill.SkillName == name)
                {
                    skill.Statement = skill.stByImg;
                }
            }
        }

        public static Image GetImage(string name)
        {
            foreach (var skill in Buttons)
            {
                if (skill.SkillName == name)
                {
                    return skill.stByImg;
                }
            }

            return null;
        }

    }
}
