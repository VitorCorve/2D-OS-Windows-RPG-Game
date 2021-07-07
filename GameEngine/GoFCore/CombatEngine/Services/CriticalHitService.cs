using GameEngine.CombatEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.CombatEngine.Services
{
    public class CriticalHitService : ICritical
    {
        public bool Critical { get; private set; }
        public CriticalHitService(double criticalChance)
        {
            Random rand = new Random();

            if (criticalChance < rand.Next(0, 100))
                Critical = true;
        }
    }
}
