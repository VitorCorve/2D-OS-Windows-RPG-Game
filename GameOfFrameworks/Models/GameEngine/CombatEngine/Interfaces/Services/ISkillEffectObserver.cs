using GameEngine.Player;
using System.Collections.Generic;

namespace GameEngine.CombatEngine.Interfaces.Services
{
    public interface ISkillEffectObserver
    {
        List<ISkill> EffectsOnDealer { get; }
        List<ISkill> EffecrsOnTarget { get; }
        List<ISkill> DealerCoolDowns { get; }
        PlayerSkillList DealerSkillList { get; }
        void AddDealerCooldown(ISkill skill);
        void AddEffectOnDealer(ISkill skill);
        void AddEffectOnTarget(ISkill skill);
        void RemoveDealerCooldown(ISkill skill);
        void RemoveEffectFromDealer(ISkill skill);
        void RemoveEffectFromTarget(ISkill skill);
    }
}
