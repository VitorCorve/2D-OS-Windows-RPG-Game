using GameEngine.Player.ConsumableResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Abstract.PlayerConsumable
{
    public interface IConsumableResource
    {
        CONSUMABLE_NAME Name { get; }
        int Value { get; }
    }
}
