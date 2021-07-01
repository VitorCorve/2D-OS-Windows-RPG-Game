using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Player.Abstract
{
    public interface IAttributes
    {
        uint Strength { get; set; }
        uint Stamina { get; set; }
        uint Intellect { get; set; }
        uint Agility { get; set; }
        uint Endurance { get; set; }
        uint WeaponDamageValue { get; set; }
        uint ArmorValue { get; set; }
    }
}
