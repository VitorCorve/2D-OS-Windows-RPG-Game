using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Player.Abstract
{
    public abstract class AbstractAttributes
    {
        public uint Strength { get; protected set; }
        public uint Stamina { get; protected set; }
        public uint Intellect { get; protected set; }
        public uint Agility { get; protected set; }
        public uint Endurance { get; protected set; }
        public uint WeaponDamageValue { get; protected set; }
        public uint ArmorValue { get; protected set; }
    }
}
