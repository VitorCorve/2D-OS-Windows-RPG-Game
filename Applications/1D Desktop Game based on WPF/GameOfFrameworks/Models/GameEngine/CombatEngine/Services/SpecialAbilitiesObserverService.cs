using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Interfaces.Services;
using GameEngine.CombatEngine.Interfaces.SkillMechanics;
using GameEngine.Player.ConditionResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.CombatEngine.Services
{
    public class SpecialAbilitiesObserverService : ISpecialAbilitiesObserverService, IDefaultBuffResourceValues
    {
        public List<ISpecialSkill> Skills { get; private set; } = new List<ISpecialSkill> { };
        public Dictionary<ISpecialSkill, double> DefaultResourceValues { get; private set; } = new Dictionary<ISpecialSkill, double> { };
        public PlayerEntity Dealer { get; private set; }

        public SpecialAbilitiesObserverService(PlayerEntity dealer, params ISkill[] skills)
        {
            Dealer = dealer;

            foreach (var skill in skills)
            {
                if (skill is ISpecialSkill)
                {
                    var specialSkill = (ISpecialSkill)skill;
                    Skills.Add(specialSkill);
                    specialSkill.Buff += Activate;
                    specialSkill.BuffFade += Cancel;
                }
            }
        }
        public SpecialAbilitiesObserverService(PlayerEntity dealer,  List<ISkill> skills)
        {
            Dealer = dealer;

            foreach (var skill in skills)
            {
                if (skill is ISpecialSkill)
                {
                    var specialSkill = (ISpecialSkill)skill;
                    Skills.Add(specialSkill);
                    specialSkill.Buff += Activate;
                    specialSkill.BuffFade += Cancel;
                }
            }
        }
        public void Activate(ISpecialSkill skill, double value)
        {
            switch (skill.SpecialResource)
            {
                case CriticalHitChance:
                    DefaultResourceValues.Add(skill, Dealer.CriticalChance.Value);
                    return;
                default:
                    break;
            }
            Dealer.SetValue(skill.SpecialResource, + value);
        }

        public void Cancel(ISpecialSkill skill)
        {
            foreach (var resource in DefaultResourceValues)
            {
                if (resource.Key.SpecialResource.GetType() == skill.SpecialResource.GetType())
                {
                    Dealer.SetValue(resource.Key.SpecialResource, resource.Value);
                }
            }
        }

    }
}
