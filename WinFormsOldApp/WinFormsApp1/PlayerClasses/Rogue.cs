using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.PlayerClasses
{
    public class Rogue : Player 
    {
        public Rogue()
        {
            baseStrength = 2;
            baseIntellect = 3;
            baseStamina = 3;
            baseEndurance = 4;
            baseAgility = 2;

            DodgeChance = Math.Round(agility * 1.3, 1);

            RefreshStats();
        }
    }
}
