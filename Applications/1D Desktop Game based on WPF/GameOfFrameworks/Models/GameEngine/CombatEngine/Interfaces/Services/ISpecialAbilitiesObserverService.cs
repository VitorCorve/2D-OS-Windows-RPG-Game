using GameEngine.CombatEngine.Interfaces.SkillMechanics;
using System.Collections.Generic;


namespace GameEngine.CombatEngine.Interfaces.Services
{
    public interface ISpecialAbilitiesObserverService
    {
        List<ISpecialSkill> Skills { get; }
        Dictionary<ISpecialSkill, double> DefaultResourceValues { get; }
        PlayerEntity Dealer { get; }
        void Activate(ISpecialSkill skill, double value);
        void Cancel(ISpecialSkill skill);
    }
}
