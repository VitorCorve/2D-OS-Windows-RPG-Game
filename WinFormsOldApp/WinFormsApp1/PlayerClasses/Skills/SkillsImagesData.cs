using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.PlayerClasses.Skills
{
    public static class SkillsImagesData
    {
        public static List<Image> Mage { get; set; }

        public static List<Image> Rogue { get; set; }

        public static List<Image> Warrior { get; set; }
        public static void InitalizeImages()
        {

            List<Image> MageSkillImages = new List<Image> { };

            List<Image> RogueSkillImages = new List<Image> { };

            List<Image> WarriorSkillImages = new List<Image> { };

            for (int i = 1; i <= 5; i++)
            {
                MageSkillImages.Add(Image.FromFile($"images\\Skills\\Mage\\{i}.jpg"));
                Mage = MageSkillImages;
            }

            for (int i = 1; i <= 5; i++)
            {
                WarriorSkillImages.Add(Image.FromFile($"images\\Skills\\Warrior\\{i}.jpg"));
                Warrior = WarriorSkillImages;
            }

            for (int i = 1; i <= 5; i++)
            {
                RogueSkillImages.Add(Image.FromFile($"images\\Skills\\Rogue\\{i}.jpg"));
                Rogue = RogueSkillImages;
            }



        }



    }


}
