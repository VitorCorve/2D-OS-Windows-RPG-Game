using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Interfaces.SkillMechanics;
using GameEngine.Player.DefenseResources;
using GameEngine.Player.PlayerConditions;
using GameEngine.SpecializationMechanics.Mage.Skills;
using GameEngine.SpecializationMechanics.Rogue.Skills;
using GameEngine.SpecializationMechanics.Warrior.Skills;
using System.Collections.Generic;
using System.Timers;

namespace GameEngine.CombatEngine.Services
{
    public class BuffsService : IBuffService, IBuffResourceType, IDefaultDebuffResourceValues, IBuffSecondResourceType
    {
        public delegate void SkillAction();
        public PlayerEntity Target { get; set; }
        public ISkill Buff { get; set; } 
        public Timer BuffTimer { get; set; }
        public int BuffValue { get; private set; }
        public int Duration { get; private set; }
        public IResourceType BuffResourceType { get; private set; }
        public IResourceType BuffSecondResourceType { get; set; }
        public double DefaultResourceValue { get; private set; }
        public BuffsService(IBuffSkill buff, PlayerEntity target)
        {
            Buff = buff;
            Target = target;
            Duration = buff.Duration;
            BuffValue = buff.AmountOfValue;
            BuffResourceType = buff.BuffResourceType;

            if (buff is IBuffSecondResourceType)
                BuffSecondResourceType = ((IBuffSecondResourceType)buff).BuffSecondResourceType;
        }
        public BuffsService(IDebuffSkill buff, PlayerEntity target)
        {
            Buff = buff;
            Target = target;
            Duration = buff.Duration;
            BuffValue = buff.AmountOfValue;

            if (buff is IBuffResourceType)
                BuffResourceType = ((IBuffResourceType)Buff).BuffResourceType;

            if (buff is ISpecialSkill)
            {
                BuffResourceType = ((ISpecialSkill)buff).BuffResourceType;

                switch (BuffResourceType)
                {
                    case Dodge:
                        DefaultResourceValue = Target.DodgeChance.Value;
                        return;
                    default:
                        break;
                }
            }
        }

        public void Cancel()
        {
            switch (Buff)
            {
                case WideBlow:
                    Target.RecoverResources.ContinueRecover(BuffResourceType);
                    ((IDebuffSkill)Buff).HarmEffectEnd();
                    return;
                case LastManStanding:
                    Target.SetValue(BuffResourceType, 1.0);
                    Target.SetValue(BuffSecondResourceType, 1.0);
                    ((IBuffSkill)Buff).EffectFade();
                    return;
                case DeepDefense:
                    Target.SetValue(BuffResourceType, 1.0);
                    Target.SetValue(BuffSecondResourceType, 1.0);
                    ((IBuffSkill)Buff).EffectFade();
                    return;
                case CrushLegs:
                    Target.SetValue(BuffResourceType, DefaultResourceValue);
                    ((IDebuffSkill)Buff).HarmEffectEnd();
                    return;
                case FindTheWeakness:
                    Target.RemoveDebuff(PLAYER_DEBUFF.FindTheWeakness);
                    ((IDebuffSkill)Buff).HarmEffectEnd();
                    return;
                case IBuffSkill:
                    // value decrases becase buff effect fades
                    Target.SetValue(BuffResourceType, - BuffValue);
                    ((IBuffSkill)Buff).EffectFade();
                    return;
                case IDebuffSkill:
                    // value increases becase debuff effect fades
                    Target.SetValue(BuffResourceType, + BuffValue);
                    ((IDebuffSkill)Buff).HarmEffectEnd();
                    return;
                default:
                    Target.ReturnControl();
                    break;
            }

        }

        public void Activate(SkillAction func = null)
        {
            if (Buff is ISkillDuration)
                ((ISkillDuration)Buff).ActiveDuration = ((ISkillDuration)Buff).Duration;
            if (BuffTimer == null)
            {
                BuffTimer = new Timer(1000);
                BuffTimer.Elapsed += Tick;
                BuffTimer.Start();
            }

            switch (Buff)
            {
                case WideBlow:
                    func?.Invoke();
                    return;
                case LastManStanding:
                    func?.Invoke();
                    return;
                case DeepDefense:
                    func?.Invoke();
                    return;
                case IBuffSkill:
                    Target.SetValue(BuffResourceType, + BuffValue);
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

            if (Buff is ISkillDuration)
                ((ISkillDuration)Buff).ActiveDuration -= 1;

            if (Duration == 0)
            {
                if (Buff is ISpecialSkill)
                    ((ISpecialSkill)Buff).CancelEffect();
                BuffTimer.Stop();
                Cancel();
            }
        }
    }
}
