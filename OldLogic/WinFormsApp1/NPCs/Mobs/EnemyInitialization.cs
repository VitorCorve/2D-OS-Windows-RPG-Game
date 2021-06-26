using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.NPCs.Mobs.Images;

namespace WinFormsApp1.NPCs.Mobs
{
    public static class EnemyInitialization
    {

        private static int playerLevel;

        public static object NPC;

        private static void GetPlayerLevel()
        {
            Player player = (Player)Data.GetPlayer();
            playerLevel = player.GetLevel();
        }

        private static void ChooseEnemyByLevel()
        {
            Random setLevel = new Random();

            NPCImagesData.Initialize();

            switch (playerLevel)
            {
 

                case >= 1 and < 3:
                    NPC = new Rat(setLevel.Next(playerLevel-2, playerLevel+2));
                    break;
                case >= 3 and < 6:
                    NPC = new Bear(setLevel.Next(playerLevel - 2, playerLevel + 2));


                    break;
                case >= 6:
                    NPC = new Bandit(setLevel.Next(playerLevel - 2, playerLevel + 2));
                    break;
                default:
                    break;
            }
        }

        public static object Initialize()
        {
            GetPlayerLevel();
            ChooseEnemyByLevel();
            return NPC;
        }
    }
}
