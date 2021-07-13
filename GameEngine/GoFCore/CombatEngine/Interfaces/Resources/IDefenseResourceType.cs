using GameEngine.Player.ConditionResources;

namespace GameEngine.CombatEngine.Interfaces
{
    public interface IDefenseResourceType : IResourceType
    {
        double Value { get; }
        double MaxValue { get; }
    }
}
