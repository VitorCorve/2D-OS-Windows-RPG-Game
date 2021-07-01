using System;
using GameEngine.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Specializatons
{
    public class Warrior : AbstractPlayer
    {

        public Warrior()
        {
            Specialization = "warrior";
        }
    }
}
