using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.PlayerClasses.Skills
{
    public static class SkillsDescription
    {
        public static Dictionary<string, string> MageSkillsDescription;
        public static Dictionary<string, string> RogueSkillsDescription;
        public static Dictionary<string, string> WarriorSkillsDescription;

        public static List<string> MageSkillNames;
        public static List<string> RogueSkillNames;
        public static List<string> WarriorSkillNames;

        public static void GetDescription()
        {
            MageSkills();
            WarriorSkills();
            RogueSkills();

        }

        private static void MageSkills()
        {
            Dictionary<string, string> description = new Dictionary<string, string> { };


            description.Add("1", File.ReadAllText("Data\\skills\\Description\\Mage\\Fireball.txt"));
            description.Add("2", File.ReadAllText("Data\\skills\\Description\\Mage\\MagicShield.txt"));
            description.Add("3", File.ReadAllText("Data\\skills\\Description\\Mage\\Polymorph.txt"));
            description.Add("4", File.ReadAllText("Data\\skills\\Description\\Mage\\SoulBurn.txt"));
            description.Add("5", File.ReadAllText("Data\\skills\\Description\\Mage\\Heal.txt"));

            MageSkillsDescription = description;

            List<string> skillNames = new List<string> { };


            skillNames.Add("Fireball");
            skillNames.Add("Magic Shield");
            skillNames.Add("Polymorph");
            skillNames.Add("Soul Burn");
            skillNames.Add("Heal");

            MageSkillNames = skillNames;

        }

        private static void WarriorSkills()
        {
            Dictionary<string, string> description = new Dictionary<string, string> { };


            description.Add("4", File.ReadAllText("Data\\skills\\Description\\Warrior\\CrushLegs.txt"));
            description.Add("2", File.ReadAllText("Data\\skills\\Description\\Warrior\\DeepDefense.txt"));
            description.Add("5", File.ReadAllText("Data\\skills\\Description\\Warrior\\LastManStanding.txt"));
            description.Add("1", File.ReadAllText("Data\\skills\\Description\\Warrior\\PowerHit.txt"));
            description.Add("3", File.ReadAllText("Data\\skills\\Description\\Warrior\\WideBlow.txt"));

            WarriorSkillsDescription = description;

            List<string> skillNames = new List<string> { };

            skillNames.Add("Power Hit");
            skillNames.Add("Deep Defense");
            skillNames.Add("Wide Blow");
            skillNames.Add("Crush Legs");
            skillNames.Add("Last Man Standing");

            WarriorSkillNames = skillNames;
        }

        private static void RogueSkills()
        {
            Dictionary<string, string> description = new Dictionary<string, string> { };


            description.Add("1", File.ReadAllText("Data\\skills\\Description\\Rogue\\Backstab.txt"));
            description.Add("4", File.ReadAllText("Data\\skills\\Description\\Rogue\\DissapearIntoTheShadows.txt"));
            description.Add("5", File.ReadAllText("Data\\skills\\Description\\Rogue\\FindTheWeakness.txt"));
            description.Add("2", File.ReadAllText("Data\\skills\\Description\\Rogue\\Rend.txt"));
            description.Add("3", File.ReadAllText("Data\\skills\\Description\\Rogue\\Stun.txt"));

            RogueSkillsDescription = description;

            List<string> skillNames = new List<string> { };

            skillNames.Add("Backstab");
            skillNames.Add("Rend");
            skillNames.Add("Stun");
            skillNames.Add("Dissapears Into The Shadows");
            skillNames.Add("Find The Weakness");

            RogueSkillNames = skillNames;

        }


    }
}
