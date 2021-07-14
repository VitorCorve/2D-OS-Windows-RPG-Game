using GameEngine.CombatEngine.Interfaces;
using GameEngine.Player.PlayerConditions;
using GameEngine.SpecializationMechanics.Mage.Skills;
using GameEngine.SpecializationMechanics.Rogue.Skills;
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
        public IResourceType BuffResourceType { get; private set; }

        public BuffsService(IBuffSkill buff, PlayerEntity target)
        {
            Buff = buff;
            Target = target;
            Duration = buff.Duration;
            BuffValue = buff.AmountOfValue;
            BuffResourceType = buff.BuffResourceType;
        }

        public BuffsService(IDebuffSkill buff, PlayerEntity target)
        {
            Buff = buff;
            Target = target;
            Duration = buff.Duration;
            BuffValue = buff.AmountOfValue;
        }

        public void Cancel()
        {
            switch (Buff)
            {
                case IBuffSkill:
                    Target.DecreaseValue(BuffResourceType, BuffValue);
                    return;
                case FindTheWeakness:
                    Target.RemoveDebuff(PlayerDebuff.FindTheWeakness);
                    return;
                default:
                    Target.ReturnControl();
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
                    Target.IncreaseValue(BuffResourceType, BuffValue);
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
    }
}
