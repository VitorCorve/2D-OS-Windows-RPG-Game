using GameEngine.CombatEngine;
using GameEngine.CombatEngine.ActionTypes;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Interfaces.SkillMechanics;
using GameEngine.CombatEngine.Services;
using GameEngine.Player.ConditionResources;

namespace GameEngine.SpecializationMechanics.Mage.Skills
{
    public class Fireball : IDamageSkill, ISkillDamageValue
    {
        public string SkillName { get ; private set; } = "Fireball";
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
        public int CoolDownDuration { get; set; } = 3;
        public int CoolDown { get; set; }
        public CriticalHitChance CriticalChance { get ; private set; }
        public int Cost { get ; private set; }
        public int SkillDamageValue
        {
            get { return RandomizeDamageValue(_skillDamageValue); }
            private set { _skillDamageValue = value; }
        }
        private int _skillDamageValue;
        public int AmountOfValue { get; private set; }
        public IResourceType ResourceType { get; set; } = new Mana();
        public IUseType Type { get; set; } = new Magic();

        public int RandomizeDamageValue(int damageValue)
        {
            var skillValueValidation = new CalculateSkillValueService(CriticalChance, damageValue);
            return skillValueValidation.SkillValue;
        }
        public void Use(int dealerAttackPower, PlayerEntity target)
        {
            CriticalChance = target.CriticalChance;
            AmountOfValue = (dealerAttackPower + SkillDamageValue) - target.ArmorPoints.Value;
            target.ReceiveDamage(AmountOfValue);
            var coolDown = new CoolDownService(this);
            coolDown.Activate();
        }
        private void ConvertValues()
        {
            Cost = SkillLevel * 3;
            SkillDamageValue = SkillLevel * 5;
        }
    }
}
