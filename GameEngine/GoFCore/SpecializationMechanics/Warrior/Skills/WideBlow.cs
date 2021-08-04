using GameEngine.CombatEngine;
using GameEngine.CombatEngine.ActionTypes;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Interfaces.SkillMechanics;
using GameEngine.CombatEngine.Services;
using GameEngine.Player.ConditionResources;
using GameEngine.Player.PlayerConditions;

namespace GameEngine.SpecializationMechanics.Warrior.Skills
{
    public class WideBlow : IDamageSkill, ISkillDamageValue, IBuffSkill
    {
        public string SkillName { get; private set; } = "Wide blow";
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
        public int CoolDownDuration { get; set; } = 15;
        public int CoolDown { get; set; }
        public int Cost { get; private set; }
        public int AmountOfValue { get; private set; }
        public IResourceType ResourceType { get; set; } = new Energy();
        public IUseType Type { get; set; } = new Melee();
        public IResourceType BuffResourceType { get; set; } = new Health();
        public CriticalHitChance CriticalChance { get; private set; }
        public int SkillDamageValue
        {
            get { return RandomizeDamageValue(_skillDamageValue); }
            private set { _skillDamageValue = value; }
        }
        private int _skillDamageValue;

        public int RandomizeDamageValue(int damageValue)
        {
            var skillValueValidation = new CalculateSkillValueService(CriticalChance, damageValue);
            return skillValueValidation.SkillValue;
        }
        public void Use(int dealerAttackPower, PlayerEntity target)
        {
            CriticalChance = target.CriticalChance;
            double incomingDamage = ((dealerAttackPower + SkillDamageValue) - target.ArmorPoints.Value) * target.Defense.IncomingDamageDivider;
            AmountOfValue = (int)incomingDamage;

            if (AmountOfValue < (target.ArmorPoints.Value / 10))
                AmountOfValue = target.ArmorPoints.Value / 10;

            var buffService = new BuffsService(this, target);
            var coolDown = new CoolDownService(this);
            coolDown.Activate();

            buffService.Activate(() => target.RecoverResources.StopRecover(BuffResourceType));

            target.ReceiveDamage(AmountOfValue);
        }
        private void ConvertValues()
        {
            Cost = SkillLevel * 3;
            AmountOfValue = SkillLevel * 5;
        }
    }
}
