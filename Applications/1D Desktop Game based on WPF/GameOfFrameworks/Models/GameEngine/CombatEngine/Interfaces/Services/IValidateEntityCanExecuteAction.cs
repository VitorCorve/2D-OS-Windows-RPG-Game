using GameEngine.Player.PlayerConditions;
using System.Collections.Generic;

namespace GameEngine.CombatEngine.Interfaces
{
    public interface IValidateEntityCanExecuteAction
    {
        PlayerControl OutOfControl { get; }
        List<IConditionResourceType> Resources { get; }
    }
}
