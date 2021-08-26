using GameEngine.CombatEngine.Interfaces.SkillMechanics;

namespace GameEngine.CombatEngine.Interfaces
{
    public interface IBuffSkill : ISkill, ISkillDuration, IBuffResourceType
    {
        event CoolDownObserver NotifyEffectApears;
        event CoolDownObserver NotifyEffectFade;
        void EffectFade();
    }
}
