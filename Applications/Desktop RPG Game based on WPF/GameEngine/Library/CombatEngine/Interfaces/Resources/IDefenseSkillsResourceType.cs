using GameEngine.Player.ConditionResources;

namespace GameEngine.CombatEngine.Interfaces
{
    public interface IDefenseSkillsResourceType : IResourceType
    {
        double Value { get; }
        double ValidateValue(double value);
    }
}
