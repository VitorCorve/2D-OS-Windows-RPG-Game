using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Player.Abstract
{
    public interface IEntityAttributes
    {
        int Strength { get; set; }
        int Stamina { get; set; }
        int Intellect { get; set; }
        int Agility { get; set; }
        int Endurance { get; set; }
        int WeaponDamageValue { get; set; }
        int ArmorValue { get; set; }
    }
}
