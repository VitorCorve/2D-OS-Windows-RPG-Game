using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Interfaces.SkillMechanics;
using GameEngine.Player.ConditionResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace GameEngine.CombatEngine.Services
{
    public class DamageOverTimeService : IDamageOverTimeService
    {
        public int DamageValue { get; private set; }
        public int Duration { get; private set; }
        public CriticalHitChance CriticalChance { get; private set; }
        public int Intervals { get; private set; }
        public Timer DurationTimer { get; private set; }
        public PlayerEntity Target { get; private set; }
        public IDebuffSkill Debuff { get; private set; }

        public DamageOverTimeService(PlayerEntity target, IDamageOverTimeSkill debuff)
        {
            Debuff = debuff;
            DamageValue = debuff.SkillDamageValue;
            Duration = debuff.Duration;
            CriticalChance = target.CriticalChance;
            Intervals = debuff.Intervals;
            Target = target;

            if (Debuff is ISkillDuration)
                Debuff.ActiveDuration = Debuff.Duration;
        }

        public void Activate()
        {
            DurationTimer = new Timer(1000);
            DurationTimer.Elapsed += Tick;
            DurationTimer.Start();
        }

        private void Tick(object sender, EventArgs e)
        {
            if (Duration == 0)
            {
                Cancel();
                return;
            }

            Duration -= 1;
            Debuff.ActiveDuration -= 1;

            if (Duration % Intervals == 0)
            { 
                int skillValueValidation = new CalculateSkillValueService(CriticalChance, DamageValue).SkillValue; 
                Target.ReceiveDamgeOverTime(Debuff, skillValueValidation);
            }
        }

        private void Cancel()
        {
            DurationTimer.Stop();
            Debuff.HarmEffectEnd();
        }
    }
}
