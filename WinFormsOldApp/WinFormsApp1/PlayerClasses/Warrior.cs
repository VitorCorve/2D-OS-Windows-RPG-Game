using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.PlayerClasses
{
    class Warrior : Player
    {
        public Warrior()
        {
            baseStrength = 5;
            baseIntellect = 2;
            baseStamina = 4;
            baseEndurance = 2;
            baseAgility = 2;

            DodgeChance = Math.Round(agility * 1.1, 1);

            RefreshStats();
        }
    }
}
