using GameEngine.Player.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Player.Specializatons.Mage
{
    public class MageBasicAttributes : IAttributes
    {
        public uint Strength { get; set; }
        public uint Stamina { get; set; }
        public uint Intellect { get; set; }
        public uint Agility { get; set; }
        public uint Endurance { get; set; }
        public uint WeaponDamageValue { get; set; }
        public uint ArmorValue { get; set; }
        public MageBasicAttributes()
        {
            Strength = 4;
            Stamina = 3;
            Intellect = 7;
            Agility = 2;
            Endurance = 2;
        }
    }
}
