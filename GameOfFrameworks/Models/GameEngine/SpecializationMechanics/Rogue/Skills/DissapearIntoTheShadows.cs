using GameEngine.CombatEngine;
using GameEngine.CombatEngine.ActionTypes;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Interfaces.SkillMechanics;
using GameEngine.CombatEngine.Services;
using GameEngine.Player.ConditionResources;
using GameEngine.Player.DefenseResources;
using static GameEngine.CombatEngine.Interfaces.ISkill;

namespace GameEngine.SpecializationMechanics.Rogue.Skills
{
    public class DissapearIntoTheShadows : IBuffSkill, ISkillDuration
    {
        public event CoolDownObserver NotifyCooldownStart;
        public event CoolDownObserver NotifyCooldownEnd;
        public event CoolDownObserver NotifyEffectApears;
        public event CoolDownObserver NotifyEffectFade;
        public int Skill_ID { get; } = 8;
        public string SkillName { get; private set; } = "Dissapear into the Shadows";
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
        public IResourceType ResourceType { get; set; } = new Mana();
        public IUseType Type { get; set; } = new Magic();
        public IResourceType BuffResourceType { get; set; } = new Dodge();

        public void Use(int dealerAttackPower, PlayerEntity target)
        {
            AmountOfValue = 100;

            var buffService = new BuffsService(this, target);
            buffService.Activate();

            var coolDown = new CoolDownService(this);
            coolDown.Activate();

            NotifyEffectApears?.Invoke(this);
            NotifyCooldownStart?.Invoke(this);
        }
        private void ConvertValues()
        {
            Cost = SkillLevel * 3;
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
