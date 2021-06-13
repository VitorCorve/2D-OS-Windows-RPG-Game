using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class NPC : Player
    {
        public string NPCAvatarPath;
        public string NPCIconPath;
        public NPC(string name, string gender) : base(name, gender)
        {

        }
        public NPC()
        {

        }
        public void Kill()
        {
            healthpoints = 0;
        }

        public void RecoverNPC()
        {
            if (WideBlow)
            {
                return;
            }
            if (healthpoints < maxHP)
            {
                healthpoints += healthRegen;

                if (healthpoints > maxHP)
                {
                    healthpoints = maxHP;
                }
            }

            if (energy < maxEnergy)
            {
                energy += energyRegen;
                if (energy > maxEnergy)
                {
                    energy = maxEnergy;
                }
            }

            if (mana < maxMana)
            {
                mana += manaRegen;
                if (mana > maxMana)
                {
                    mana = maxMana;
                }
            }

            if (healthpoints < 0 && healthpoints == 0)
            {
                IsAlive = false;
                healthpoints = 0;
            }
        }
    }
}
