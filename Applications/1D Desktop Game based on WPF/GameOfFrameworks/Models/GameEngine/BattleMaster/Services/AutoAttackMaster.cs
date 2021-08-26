using GameEngine.BattleMaster.Interfaces.Services;
using GameEngine.CombatEngine;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.SpecializationMechanics.UniversalSkills;
using System;
using System.Timers;

namespace GameEngine.BattleMaster.Services
{
    public class AutoAttackMaster : IAutoAttackMaster
    {
        public ISkill SkillToAttack { get; } = new RegularAttack();
        public Timer AutoAttackTimer { get; set; }
        public CombatManager PlayerCombatManager { get; set; }
        public CombatManager NPC_CombatManager { get; set; }
        public AutoAttackMaster(CombatManager dealerCombatManager, CombatManager targetCombatManager)
        {
            PlayerCombatManager = dealerCombatManager;
            NPC_CombatManager = targetCombatManager;
        }
        public void RunAutoAttack()
        {
            AutoAttackTimer = new Timer(2000);
            AutoAttackTimer.Elapsed += TimerTick;
            AutoAttackTimer.Start();
        }
        public void StopAutoAttack()
        {
            AutoAttackTimer.Stop();
        }

        public void TimerTick(object sender, ElapsedEventArgs e)
        {
            PlayerCombatManager.Action(SkillToAttack);
            System.Threading.Thread.Sleep(850);
            NPC_CombatManager.Action(SkillToAttack);
        }
    }
}
