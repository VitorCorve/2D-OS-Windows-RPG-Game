using GameEngine.CombatEngine;
using GameEngine.CombatEngine.ActionTypes;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Services;
using GameEngine.Player.ConditionResources;
using System.Timers;

namespace GameEngine.SpecializationMechanics.Mage.Skills
{
    public class Soulburn : IDamageOverTimeSkill
    {
        public string SkillName { get; private set; }
        public int SkillLevel { get; private set; }
        public Timer CoolDownTimer { get; private set; }
        public int Duration { get;  set; }
        public int CoolDownDuration { get; set; }
        public int CoolDown { get; set; }
        public bool ReadyToUse { get; private set; }
        public bool SkillAffectedOnEnemy { get; private set; }
        public double CriticalChance { get; private set; }
        public int Cost { get; private set; }
        public int Intervals { get; private set; }

        private int _skillDamageValue;
        public int SkillDamageValue
        {
            get { return RandomizeDamageValue(_skillDamageValue); }
            private set { _skillDamageValue = value; } 
        }
        public int AmountOfDamage { get; private set; }
        public IResourceType ResourceType { get; set; } = new Mana();
        public IAttackType Type { get; set; } = new Magic();
        public IValueType ValueType { get; set; }

        public int RandomizeDamageValue(int damageValue)
        {
            var skillValueValidation = new CalculateSkillValueService(CriticalChance, damageValue);
            return skillValueValidation.SkillValue;
        }

        public void Use(int dealerAttackPower, PlayerEntity target)
        {
            CriticalChance = target.CriticalHitChance;
            AmountOfDamage = (dealerAttackPower + SkillDamageValue) - target.ArmorPoints.Value;

            var damageOverTimeService = new DamageOverTimeService(target, this);

            var coolDown = new CoolDownService(this);

            damageOverTimeService.Activate();
            coolDown.Activate();
        }

        public Soulburn(int skillLevel)
        {
            SkillName = "Soul Burn";
            SkillLevel = skillLevel;
            SkillDamageValue = SkillLevel * 5;
            Cost = SkillLevel * 3;
            CoolDownDuration = 12;
            Duration = 10;
            Intervals = 2;
        }
    }
}
