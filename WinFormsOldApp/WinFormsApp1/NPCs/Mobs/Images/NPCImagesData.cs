using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.NPCs.Mobs.Images
{
    public static class NPCImagesData
    {
        public static List<string> BanditsImages;
        public static List<string> RatsImages;
        public static List<string> BearsImages;

        public static List<string> BanditsIcons;
        public static List<string> BearsIcons;
        public static List<string> RatsIcons;

        public static int RandomChoise;

        public static void Initialize()
        {
            SetImagesPath();
        }

        private static void SetImagesPath()
        {
        List<string> banditsImages = new List<string> { };
        List<string> ratsImages = new List<string> { };
        List<string> bearsImages = new List<string> { };

        List<string> banditsIcons = new List<string> { };
        List<string> bearsIcons = new List<string> { };
        List<string> ratsIcons = new List<string> { };


            for (int i = 1; i <= 3; i++)
            {
                banditsImages.Add($"images\\npcs\\enemies\\bandits\\{i}.jpg");
                ratsImages.Add($"images\\npcs\\enemies\\rats\\{i}.jpg");
                bearsImages.Add($"images\\npcs\\enemies\\bears\\{i}.jpg");

                banditsIcons.Add($"images\\npcs\\enemies\\bandits\\{i}.png");
                ratsIcons.Add($"images\\npcs\\enemies\\rats\\{i}.png");
                bearsIcons.Add($"images\\npcs\\enemies\\bears\\{i}.png");
            }

            RatsImages = ratsImages;
            RatsIcons = ratsIcons;

            BearsImages = bearsImages;
            BearsIcons = bearsIcons;

            BanditsImages = banditsImages;
            BanditsIcons = banditsIcons;
            
        }

        public static string GetImagePath(string npcClass)
        {
            Random choise = new Random();
            RandomChoise = choise.Next(0, 2);

                switch (npcClass)
                {
                    case "rat":
                        return RatsImages[RandomChoise];
                    case "bear":
                        return BearsImages[RandomChoise];
                    case "bandit":
                        return BanditsImages[RandomChoise];
                    default:
                        break;
                }
                return "";
        }

        public static string GetIconPath(string npcClass)
        {
            Random choise = new Random();

            switch (npcClass)
            {
                case "rat":
                    return RatsIcons[RandomChoise];
                case "bear":
                    return BearsIcons[RandomChoise];
                case "bandit":
                    return BanditsIcons[RandomChoise];
                default:
                    break;
            }
            return "";
        }
    }
}
