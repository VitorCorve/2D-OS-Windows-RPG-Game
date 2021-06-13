using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public static class Experience
    {

        public static bool AddExperience(Player player, NPC npc)
        {
            //player.SetExperience(npc.GetLevel() * 4);
            player.AddExperience(npc.GetLevel() * 2);

            if (player.GetExperience() == player.GetMaxExperience())
            {
                player.LevelUp();
                player.SetMaxExperience();
                player.NullExperience();
                player.RefreshStats();
                Data.SetPlayer(player);
                return true;
            }

            if (player.GetExperience() > player.GetMaxExperience())
            {
                player.LevelUp();
                player.SetMaxExperience();
                player.NullExperience();
                player.RefreshStats();
                Data.SetPlayer(player);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
