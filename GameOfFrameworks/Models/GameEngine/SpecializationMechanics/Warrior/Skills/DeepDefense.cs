using GameEngine.CombatEngine;
using GameEngine.CombatEngine.ActionTypes;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Interfaces.SkillMechanics;
using GameEngine.CombatEngine.Services;
using GameEngine.Player.ConditionResources;
using static GameEngine.CombatEngine.Interfaces.ISkill;

namespace GameEngine.SpecializationMechanics.Warrior.Skills
{
    public class DeepDefense : IBuffSkill, ISkillDuration, IBuffSecondResourceType
    {
        public event CoolDownObserver NotifyCooldownStart;
        public event CoolDownObserver NotifyCooldownEnd;
        public event CoolDownObserver NotifyEffectApears;
        public event CoolDownObserver NotifyEffectFade;
        public int Skill_ID { get; } = 13;
        public string SkillName { get; private set; } = "Deep defense";
        public int SkillLevel
        {
            get { return _SkillLevel; }
            set
            {
                _SkillLevel = value;
                ConvertValues();
            }
        }
        private int _SkillLevel;
        public int Duration { get; set; } = 8;
        public int ActiveDuration { get; set; }
        public int CoolDownDuration { get; set; } = 20;
        public int CoolDown { get; set; }
        public int Cost { get; private set; }
        public int AmountOfValue { get; private set; }
        public IResourceType ResourceType { get; set; } = new Energy();
        public IUseType Type { get; set; } = new Melee();
        public IResourceType BuffResourceType { get; set; } = new DefensePower();
        public IResourceType BuffSecondResourceType { get; set; } = new AttackPower();

        public void Use(int dealerAttackPower, PlayerEntity target)
        {
            double buffValue = (10.0 - AmountOfValue) / 10;
            var buffService = new BuffsService(this, target);
            buffService.Activate(() => target.SetValue(BuffResourceType, buffValue));
            buffService.Activate(() => target.SetValue(BuffSecondResourceType, buffValue / 3));

            var coolDown = new CoolDownService(this);
            coolDown.Activate();

            NotifyEffectApears?.Invoke(this);
            NotifyCooldownStart?.Invoke(this);
        }
        private void ConvertValues()
        {
            Cost = SkillLevel * 2;
            AmountOfValue = SkillLevel;
        }
        public void CoolDownEnd()
        {
            NotifyCooldownEnd?.Invoke(this);
        }
        public void EffectFade()
        {
            NotifyEffectFade?.Invoke(this);
        }
    }
}
