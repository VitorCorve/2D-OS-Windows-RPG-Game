using GameEngine.CombatEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace GameEngine.CombatEngine.Services
{
    public class DamageOverTimeService : IDamageOverTime
    {
        public int DamageValue { get; private set; }
        public int Duration { get; private set; }
        public double CriticalChance { get; private set; }
        public int Intervals { get; private set; }
        public Timer DurationTimer { get; private set; }
        public PlayerEntity Target { get; private set; }
        public IDebuffSkill Debuff { get; private set; }

        public DamageOverTimeService(PlayerEntity target, IDamageOverTimeSkill debuff)
        {
            DamageValue = debuff.SkillDamageValue;
            Duration = debuff.Duration;
            CriticalChance = target.CriticalHitChance;
            Intervals = debuff.Intervals;
            Target = target;
        }

        public void Activate()
        {
            DurationTimer = new Timer(1000 * Intervals);
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

            int skillValueValidation = new CalculateSkillValueService(CriticalChance, DamageValue).SkillValue;
            Target.ReceiveDamage(skillValueValidation);

            Duration -= 1;
        }

        private void Cancel()
        {
            DurationTimer.Stop();
        }
    }
}
