using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.NPCs.Mobs.Images;

namespace WinFormsApp1.NPCs.Mobs
{
    class Bandit : NPC
    {


        List<string> names = new List<string>
        {
            "Stranger from the wide road",
            "Hunter",
            "Bandit",
            "Rogue",
            "Thief",
        };
        public override void RefreshStats()
        {
            Player player = (Player)Data.GetPlayer();
            Random statsScatter = new Random();

            Kind = "human";

            strength = player.baseStrength * statsScatter.Next(7, 12) / 10;
            intellect = player.intellect * statsScatter.Next(7, 12) / 10;
            stamina = player.baseStamina * statsScatter.Next(7, 12) / 10;
            agility = player.agility * statsScatter.Next(7, 12) / 10;
            endurance = player.endurance * statsScatter.Next(7, 12) / 10;

            healthpoints = BaseHP + level + statsScatter.Next(baseStamina * 10, baseStamina * 12);


            maxHP = healthpoints;

            energy = level + statsScatter.Next(endurance * 5, endurance * 9);
            maxEnergy = energy;

            attackPower = level + statsScatter.Next(baseStrength * 5, baseStrength * 7);
            //attackPower = 3;
            attackSpeed = 1.8;

            mana = level + intellect * 3;
            maxMana = level + intellect * 3;

            healPower = level + intellect * 1;

            Armor = 5;



            healthRegen = stamina / 4;
            manaRegen = maxMana / 50;
            energyRegen = maxEnergy / 20;

            CriticalChance = 5;

            BasicMagicResistChance = intellect;
            // MagicResistChance = BasicMagicResistChance + AdditionalMagicResistChance;
            MagicResistChance = 0;
        }

        public Bandit(int level)
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
            NPCAvatarPath = NPCImagesData.GetImagePath("bandit");
            NPCIconPath = NPCImagesData.GetIconPath("bandit");
            RefreshStats();
        }

        public Bandit()
        {

        }
    }
}
