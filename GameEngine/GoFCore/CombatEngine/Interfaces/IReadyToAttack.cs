using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.CombatEngine.Interfaces
{
    public interface IReadyToAttack
    {
        bool OutOfControl { get; }
        ISkill SkillToUse { get; }
        List<IResourceType> Resources { get; }
    }
}
