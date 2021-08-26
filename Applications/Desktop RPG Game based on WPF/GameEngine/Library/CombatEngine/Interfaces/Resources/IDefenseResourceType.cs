using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.CombatEngine.Interfaces.Resources
{
    public interface IDefenseResourceType : IResourceType
    {
        double IncomingDamageDivider { get; }
    }
}
