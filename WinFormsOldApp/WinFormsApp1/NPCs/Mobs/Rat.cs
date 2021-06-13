using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.NPCs.Mobs.Images;

namespace WinFormsApp1.NPCs.Mobs
{
    class Rat : NPC
    {


        List<string> names = new List<string>
        {
            "Angry rat",
            "Hungry rat",
            "Sneaky rat",
            "Ugly rat",
            "Field rat",
        };
        public override void RefreshStats()
        {
            Player player = (Player)Data.GetPlayer();
            Random statsScatter = new Random();

            Kind = "rat";

            strength = player.baseStrength * statsScatter.Next(7, 12) / 10;
            intellect = player.intellect * statsScatter.Next(7, 12) / 10;
            stamina = player.baseStamina * statsScatter.Next(7, 12) / 10;
            agility = player.agility * statsScatter.Next(7, 12) / 10;
            endurance = player.endurance * statsScatter.Next(7, 12) / 10;

            healthpoints = BaseHP + level + statsScatter.Next(baseStamina * 5, baseStamina * 7);
            maxHP = healthpoints;

            energy = level + statsScatter.Next(endurance * 5, endurance * 7);
            maxEnergy = energy;

            attackPower = level + statsScatter.Next(baseStrength * 3, baseStrength * 4);
            attackSpeed = 1;

            mana = level + intellect * 3;
            maxMana = level + intellect * 3;

            healPower = level + intellect * 1;

            Armor = 2;



            healthRegen = stamina / 4;
            manaRegen = maxMana / 50;
            energyRegen = maxEnergy / 20;

            CriticalChance = level + agility;
        }

        public Rat(int level)
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
            NPCAvatarPath = NPCImagesData.GetImagePath("rat");
            NPCIconPath = NPCImagesData.GetIconPath("rat");
            RefreshStats();
        }
        public Rat()
        {

        }
    }
}
