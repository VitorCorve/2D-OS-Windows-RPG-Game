using GameEngine.Player.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Player.Specializatons.Rogue
{
    public class RogueBasicAttributes : IAttributes
    {
        public uint Strength { get; set; }
        public uint Stamina { get; set; }
        public uint Intellect { get; set; }
        public uint Agility { get; set; }
        public uint Endurance { get; set; }
        public uint WeaponDamageValue { get; set; }
        public uint ArmorValue { get; set; }
        public RogueBasicAttributes()
        {
            Strength = 5;
            Stamina = 4;
            Intellect = 4;
            Agility = 6;
            Endurance = 5;
        }

    }
}
