using GameEngine.Player.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Player.Specializatons.Rogue
{
    public class EntityModel_Rogue : IEntityAttributes
    {
        public int Strength { get; set; }
        public int Stamina { get; set; }
        public int Intellect { get; set; }
        public int Agility { get; set; }
        public int Endurance { get; set; }
        public int WeaponDamageValue { get; set; }
        public int ArmorValue { get; set; }
        public EntityModel_Rogue()
        {
            Strength = 5;
            Stamina = 4;
            Intellect = 4;
            Agility = 6;
            Endurance = 5;
        }

    }
}
