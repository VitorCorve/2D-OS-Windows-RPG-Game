using GameEngine.CombatEngine.Interfaces.SkillMechanics;

namespace GameEngine.CombatEngine.Interfaces
{
    public interface IDebuffSkill : ISkill, ISkillDuration
    {
        event CoolDownObserver NotifyHarmEffectAppears;
        event CoolDownObserver NotifyHarmEffectFade;
        void HarmEffectEnd();
    }
}
