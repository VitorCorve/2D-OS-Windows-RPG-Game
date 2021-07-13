using GameEngine.CombatEngine;
using GameEngine.CombatEngine.ActionTypes;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Services;
using GameEngine.Player.ConditionResources;
using System.Timers;

namespace GameEngine.SpecializationMechanics.Mage.Skills
{
    public class Fireball : IDamageSkill
    {
        public string SkillName { get ; private set; }
        public int SkillLevel { get ; private set; }
        public Timer CoolDownTimer { get ; private set; }
        public int Duration { get ; set; }
        public int CoolDownDuration { get; set; }
        public int CoolDown { get; set; }
        public bool ReadyToUse { get ; private set; }
        public bool SkillAffectedOnEnemy { get ; private set; }
        public double CriticalChance { get ; private set; }
        public int Cost { get ; private set; }

        private int _skillDamageValue;
        public int SkillDamageValue
        {
            get { return RandomizeDamageValue(_skillDamageValue); }
            private set { _skillDamageValue = value; }
        }
        public int AmountOfValue { get; private set; }
        public IResourceType ResourceType { get; set; } = new Mana();
        public IAttackType Type { get; set; } = new Magic();
        public IResourceType ValueType { get; set; }

        public int RandomizeDamageValue(int damageValue)
        {
            var skillValueValidation = new CalculateSkillValueService(CriticalChance, damageValue);
            return skillValueValidation.SkillValue;
        }
        public void Use(int dealerAttackPower, PlayerEntity target)
        {
            CriticalChance = target.CriticalHitChance;
            AmountOfValue = (dealerAttackPower + SkillDamageValue) - target.ArmorPoints.Value;
            target.ReceiveDamage(AmountOfValue);
            var coolDown = new CoolDownService(this);
            coolDown.Activate();
        }

        public Fireball(int skillLevel)
        {
            SkillName = "Fireball";
            SkillLevel = skillLevel;
            SkillDamageValue = SkillLevel * 5;
            Cost = SkillLevel * 3;
            CoolDownDuration = 3;
        }

    }
}
