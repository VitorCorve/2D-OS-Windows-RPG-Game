using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using WinFormsApp1.PlayerClasses.Skills;

namespace WinFormsApp1.PlayerClasses
{
    class Mage : Player
    {
        public Mage()
        {
            baseStrength = 2;
            baseIntellect = 6;
            baseStamina = 3;
            baseEndurance = 2;
            baseAgility = 3;

            DodgeChance = Math.Round(agility * 0.8, 1);

            RefreshStats();
        }

    }
}
