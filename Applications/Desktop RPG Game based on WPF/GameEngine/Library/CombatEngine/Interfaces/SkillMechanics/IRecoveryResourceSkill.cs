using GameEngine.Player.ConditionResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace GameEngine.CombatEngine.Interfaces.SkillMechanics
{
    public interface IRecoveryResourceSkill
    {
        Timer RecoveryTimer { get; }
        IConditionResourceType ResourceType { get; }
        void Recover();
        void StopRecover();
        void ContinueRecover();
    }
}
