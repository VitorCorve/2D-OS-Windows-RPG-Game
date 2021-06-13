using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public static class PlayerInventory
    {


        public static void AddReward(Player player, int reward)
        {
            player.copper += reward;

            if (player.copper >= 100)
            {
                player.silver += 1;

                if (player.copper > 100)
                {
                    player.copper -= 100;
                }
            }

            if (player.silver >= 100)
            {
                player.gold += 1;

                if (player.silver > 100)
                {
                    player.silver -= 100;
                }
            }
        }
    }
}
