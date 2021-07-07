using GameEngine.CombatEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.CombatEngine.Services
{
    public class CheckAliveStatusService : IAliveStatus
    {
        public bool Alive { get; private set; } = true;
        public CheckAliveStatusService(PlayerEntity player)
        {
            if (player.HealthPoints.Value == 0)
                Alive = false;
        }
    }
}
