using GameEngine.Player.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Player.Specializatons.Rogue
{
    public class RogueBasicAttributes : AbstractAttributes
    {
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
