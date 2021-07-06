using GameEngine.CombatEngine.Interfaces;
using GameEngine.SpecializationMechanics.Mage.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace GameEngine.CombatEngine.Services
{
    public class BuffsService : IBuffService
    {
        public PlayerEntity Target { get; set; }
        public ISkill Buff { get; set; } 
        public Timer BuffTimer { get; set; }
        public uint BuffValue { get; private set; }
        public uint Duration { get; private set; }
        public IValueType Type { get; private set; }
        public BuffsService(ISkill buff, PlayerEntity target, uint duration, uint buffValue, IValueType valueType)
        {
            Buff = buff;
            Target = target;
            Duration = duration;
            BuffValue = buffValue;
            Type = valueType;
        }

        public void Cancel()
        {
            Target.DecreaseValue(Type, BuffValue);
        }

        public void Activate()
        {
            BuffTimer = new Timer(1000);
            BuffTimer.Elapsed += Tick;
            BuffTimer.Start();
            Target.IncreaseValue(Type, BuffValue);
        }

        private void Tick(object sender, ElapsedEventArgs e)
        {
            Duration -= 1;

            if (Duration == 0)
            {
                BuffTimer.Stop();
                Cancel();
            }
        }
    }
}
