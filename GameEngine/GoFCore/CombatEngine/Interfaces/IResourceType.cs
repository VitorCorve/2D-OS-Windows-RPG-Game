using GameEngine.Player.ConditionResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.CombatEngine.Interfaces
{
    public interface IResourceType
    {
        int Value { get; }
        int MaxValue { get; }
        ResourceName Name { get; }
    }
}
