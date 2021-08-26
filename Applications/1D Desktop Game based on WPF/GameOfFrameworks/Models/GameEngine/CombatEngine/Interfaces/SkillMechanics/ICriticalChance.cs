using GameEngine.Player.ConditionResources;


namespace GameEngine.CombatEngine.Interfaces.SkillMechanics
{
    public interface ICriticalChance
    {
        CriticalHitChance CriticalChance { get; }
    }
}
