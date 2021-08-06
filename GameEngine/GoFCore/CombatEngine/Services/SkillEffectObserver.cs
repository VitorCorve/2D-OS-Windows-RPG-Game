using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Interfaces.Services;
using GameEngine.Data;
using GameEngine.Player;
using System.Collections.Generic;

namespace GameEngine.CombatEngine.Services
{
    public class SkillEffectObserver : ISkillEffectObserver
    {
        public List<ISkill> EffectsOnDealer { get; } = new();
        public List<ISkill> EffecrsOnTarget { get; } = new();
        public List<ISkill> DealerCoolDowns { get; } = new();
        public PlayerSkillList DealerSkillList { get; }
        public SkillEffectObserver(PlayerLoadData playerData)
        {
            DealerSkillList = playerData.ListOfSkills;

            foreach (var skill in DealerSkillList.Skills)
            {
                skill.NotifyCooldownStart += AddDealerCooldown;
                skill.NotifyCooldownEnd += RemoveDealerCooldown;

                if (skill is IBuffSkill)
                {
                    ((IBuffSkill)skill).NotifyEffectApears += AddEffectOnDealer;
                    ((IBuffSkill)skill).NotifyEffectFade += RemoveEffectFromDealer;
                }

                if (skill is IDebuffSkill)
                {
                    ((IDebuffSkill)skill).NotifyHarmEffectAppears += AddEffectOnTarget;
                    ((IDebuffSkill)skill).NotifyHarmEffectFade += RemoveEffectFromTarget;
                }
            }
        }
        public void AddDealerCooldown(ISkill skill)
        {
            DealerCoolDowns.Add(skill);
        }
        public void RemoveDealerCooldown(ISkill skill)
        {
            DealerCoolDowns.Remove(skill);
        }
        public void AddEffectOnDealer(ISkill skill)
        {
            EffectsOnDealer.Add(skill);
        }
        public void RemoveEffectFromDealer(ISkill skill)
        {
            EffectsOnDealer.Remove(skill);
        }
        public void AddEffectOnTarget(ISkill skill)
        {
            EffecrsOnTarget.Add(skill);
        }
        public void RemoveEffectFromTarget(ISkill skill)
        {
            EffecrsOnTarget.Remove(skill);
        }
    }
}
