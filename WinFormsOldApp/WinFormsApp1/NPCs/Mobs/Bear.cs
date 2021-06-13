using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.NPCs.Mobs.Images;

namespace WinFormsApp1.NPCs.Mobs
{
    class Bear : NPC
    {


        List<string> names = new List<string>
        {
            "Slow bear",
            "Dangerous bear",
            "Hungry bear",
            "Afwul bear",
            "Grizzly bear",
        };
        public override void RefreshStats()
        {
            Player player = (Player)Data.GetPlayer();
            Random statsScatter = new Random();

            Kind = "bear";

            strength = player.baseStrength * statsScatter.Next(7, 12) / 10;
            intellect = player.intellect * statsScatter.Next(7, 12) / 10;
            stamina = player.baseStamina * statsScatter.Next(7, 12) / 10;
            agility = player.baseAgility * statsScatter.Next(7, 12) / 10;
            endurance = player.endurance * statsScatter.Next(7, 12) / 10;

            healthpoints = level + statsScatter.Next(baseStamina * 8, baseStamina * 10);
            maxHP = healthpoints;

            energy = level + statsScatter.Next(endurance * 4, endurance * 7);
            maxEnergy = energy;

            attackPower = BaseHP + level + statsScatter.Next(baseStrength * 5, baseStrength * 7);
            attackSpeed = 3;

            mana = level + intellect * 3;
            maxMana = level + intellect * 3;

            healPower = level + intellect * 1;

            Armor = 5;



            healthRegen = stamina / 4;
            manaRegen = maxMana / 50;
            energyRegen = maxEnergy / 20;
        }

        public Bear(int level)
        {
            Random getName = new Random();
            SetName(names[getName.Next(0, 5)]);
            gender = "male";
            if (level < 1)
            {
                this.level = 1;
            }
            else
            {
                this.level = level;
            }
            NPCAvatarPath = NPCImagesData.GetImagePath("bear");
            NPCIconPath = NPCImagesData.GetIconPath("bear");
            RefreshStats();
        }

        public Bear()
        {
            
        }
    }
}
