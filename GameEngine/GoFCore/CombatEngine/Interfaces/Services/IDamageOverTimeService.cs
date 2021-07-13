using GameEngine.CombatEngine.Interfaces;
using GameEngine.SpecializationMechanics.Mage.Skills;
using System.Timers;

namespace GameEngine.CombatEngine.Interfaces
{
    public interface IDamageOverTimeService
    {
        int DamageValue { get; }
        int Duration { get; }
        double CriticalChance { get; }
        int Intervals { get; }
        Timer DurationTimer { get; }
        PlayerEntity Target { get; }
        IDebuffSkill Debuff { get; }
        void Activate();
    }
}
