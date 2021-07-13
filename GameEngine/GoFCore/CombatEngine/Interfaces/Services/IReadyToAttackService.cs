using GameEngine.Player.PlayerConditions;
using System.Collections.Generic;

namespace GameEngine.CombatEngine.Interfaces
{
    public interface IReadyToAttackService
    {
        PlayerControl OutOfControl { get; }
        List<IConditionResourceType> Resources { get; }
    }
}
