using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Player.Abstract
{
    public abstract class AbstractAttributes
    {
        public uint Strength { get; set; }
        public uint Stamina { get; set; }
        public uint Intellect { get; set; }
        public uint Agility { get; set; }
        public uint Endurance { get; set; }
        public uint WeaponDamageValue { get; set; }
        public uint ArmorValue { get; set; }
    }
}
