using GameEngine.Player.PlayerConditions;
using System.Collections.Generic;

namespace GameEngine.CombatEngine.Interfaces
{
    public interface IReadyToAttack
    {
        PlayerControl OutOfControl { get; }
        List<IResourceType> Resources { get; }
    }
}
