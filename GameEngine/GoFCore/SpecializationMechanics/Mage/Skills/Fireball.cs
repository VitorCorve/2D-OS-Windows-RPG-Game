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
        public string SkillName { get ; private set; }
        public int SkillLevel { get ; private set; }
        public int CoolDownDuration { get; set; }
        public int CoolDown { get; set; }
        public CriticalHitChance CriticalChance { get ; private set; }
        public int Cost { get ; private set; }

        private int _skillDamageValue;
        public int SkillDamageValue
        {
            get { return RandomizeDamageValue(_skillDamageValue); }
            private set { _skillDamageValue = value; }
        }
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
