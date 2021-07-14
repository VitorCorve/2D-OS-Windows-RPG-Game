using GameEngine.CombatEngine.Interfaces.SkillMechanics;
using System.Timers;

namespace GameEngine.CombatEngine.Interfaces
{
    public interface IDamageOverTimeService : IDamageOverTimeIntervals
    {
        int DamageValue { get; }
        int Duration { get; }
        double CriticalChance { get; }
        Timer DurationTimer { get; }
        PlayerEntity Target { get; }
        IDebuffSkill Debuff { get; }
        void Activate();
    }
}
