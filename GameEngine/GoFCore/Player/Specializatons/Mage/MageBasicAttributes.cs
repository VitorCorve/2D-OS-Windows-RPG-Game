using GameEngine.Player.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Player.Specializatons.Mage
{
    public class MageBasicAttributes : AbstractAttributes
    {
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
