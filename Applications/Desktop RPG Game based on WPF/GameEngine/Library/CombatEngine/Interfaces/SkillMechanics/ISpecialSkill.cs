using GameEngine.CombatEngine.Delegates;

namespace GameEngine.CombatEngine.Interfaces.SkillMechanics
{
    public interface ISpecialSkill : IBuffResourceType
    {
        event SpecialAblitiesCallDelegate Buff;
        event SpecialAbilitiesFadeDelegate BuffFade;
        IResourceType SpecialResource { get; }
        void CancelEffect();
    }
}
