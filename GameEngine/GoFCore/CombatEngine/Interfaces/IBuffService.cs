using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace GameEngine.CombatEngine.Interfaces
{
    public interface IBuffService
    {
        PlayerEntity Target { get; }
        ISkill Buff { get; }
        Timer BuffTimer { get; }
        uint BuffValue { get; }
        uint Duration { get; }
        IValueType Type { get; }
        void Cancel();
    }
}
