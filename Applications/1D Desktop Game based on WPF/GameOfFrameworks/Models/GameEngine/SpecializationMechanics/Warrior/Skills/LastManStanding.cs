using GameEngine.CombatEngine;
using GameEngine.CombatEngine.ActionTypes;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Interfaces.SkillMechanics;
using GameEngine.CombatEngine.Services;
using GameEngine.Player.ConditionResources;
using static GameEngine.CombatEngine.Interfaces.ISkill;

namespace GameEngine.SpecializationMechanics.Warrior.Skills
{
    public class LastManStanding : IBuffSkill, ISkillDuration, IBuffSecondResourceType
    {
        public event CoolDownObserver NotifyCooldownStart;
        public event CoolDownObserver NotifyCooldownEnd;
        public event CoolDownObserver NotifyEffectApears;
        public event CoolDownObserver NotifyEffectFade;
        public int Skill_ID { get; } = 14;
        public string SkillName { get; private set; } = "Last man standing";
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
        public int Duration { get; set; } = 5;
        public int ActiveDuration { get; set; }
        public int CoolDownDuration { get; set; } = 20;
        public int CoolDown { get; set; }
        public int Cost { get; private set; }
        public int AmountOfValue { get; private set; }
        public IResourceType ResourceType { get; set; } = new Energy();
        public IUseType Type { get; set; } = new Melee();
        public IResourceType BuffResourceType { get; set; } = new AttackPower();
        public IResourceType BuffSecondResourceType { get; set; } = new DefensePower();

        public void Use(int dealerAttackPower, PlayerEntity target)
        {
            var buffService = new BuffsService(this, target);
            buffService.Activate(() => target.SetValue(BuffResourceType, 1.0 + (SkillLevel / 10.0)));
            buffService.Activate(() => target.SetValue(BuffSecondResourceType, 1.2));

            var coolDown = new CoolDownService(this);
            coolDown.Activate();

            NotifyEffectApears?.Invoke(this);
            NotifyCooldownStart?.Invoke(this);
        }
        private void ConvertValues()
        {
            Cost = SkillLevel * 2;
            AmountOfValue = SkillLevel * 5;
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

