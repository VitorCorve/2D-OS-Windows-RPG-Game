using GameEngine.CombatEngine;
using GameEngine.CombatEngine.Interfaces;
using System.Timers;

namespace GameEngine.BattleMaster.Interfaces.Services
{
    public interface IAutoAttackMaster
    {
        ISkill SkillToAttack { get; }
        Timer AutoAttackTimer { get; }
        CombatManager PlayerCombatManager { get; }
        CombatManager NPC_CombatManager { get; }
        void RunAutoAttack();
        void StopAutoAttack();
    }
}
