using System;
using GameEngine.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Specializatons
{
    public class Rogue : AbstractPlayer
    {
        public Rogue()
        {
            Specialization = "rogue";
        }
    }
}
