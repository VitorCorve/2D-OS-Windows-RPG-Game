using GameEngine.CombatEngine.Interfaces.SkillMechanics;
using System.Collections.Generic;
using System.Timers;

namespace GameEngine.CombatEngine.Interfaces
{
    public interface IBuffService : IBuffResourceType
    {
        PlayerEntity Target { get; }
        ISkill Buff { get; }
        Timer BuffTimer { get; }
        int BuffValue { get; }
        int Duration { get; }
        void Cancel();
    }
}
