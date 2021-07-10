using GameEngine.CombatEngine.Interfaces;
using GameEngine.SpecializationMechanics.Mage.Skills;
using System.Timers;

namespace GameEngine.CombatEngine.Services
{
    public class BuffsService : IBuffService
    {
        public delegate void SkillAction();
        public PlayerEntity Target { get; set; }
        public ISkill Buff { get; set; } 
        public Timer BuffTimer { get; set; }
        public int BuffValue { get; private set; }
        public int Duration { get; private set; }
        public IValueType Type { get; private set; }
        public BuffsService(ISkill buff, PlayerEntity target, int duration, int buffValue, IValueType valueType)
        {
            Buff = buff;
            Target = target;
            Duration = duration;
            BuffValue = buffValue;
            Type = valueType;
        }

        public void Cancel()
        {
            switch (Buff)
            {
                case IBuffSkill:
                    Target.DecreaseValue(Type, BuffValue);
                    return;
                case Polymorph:
                    ReturnControl();
                    return;
                default:
                    break;
            }

        }

        public void Activate(SkillAction func = null)
        {
            BuffTimer = new Timer(1000);
            BuffTimer.Elapsed += Tick;
            BuffTimer.Start();

            switch (Buff)
            {
                case IBuffSkill:
                    Target.IncreaseValue(Type, BuffValue);
                    return;
                case IDebuffSkill:
                    func?.Invoke();
                    return;
                default:
                    break;
            }

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

        private void ReturnControl()
        {
            Target.ReturnControl();
        }

    }
}
