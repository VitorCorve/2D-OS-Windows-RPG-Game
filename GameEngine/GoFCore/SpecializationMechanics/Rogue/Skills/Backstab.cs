using GameEngine.CombatEngine;
using GameEngine.CombatEngine.ActionTypes;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Services;
using GameEngine.Player.ConditionResources;
using GameEngine.Player.PlayerConditions;
using System.Timers;

namespace GameEngine.SpecializationMechanics.Rogue.Skills
{
    public class Backstab : IDamageSkill
    {
        public string SkillName { get; private set; }
        public int SkillLevel { get; private set; }
        public Timer CoolDownTimer { get; private set; }
        public int Duration { get; set; }
        public int CoolDownDuration { get; set; }
        public int CoolDown { get; set; }
        public bool ReadyToUse { get; private set; }
        public bool SkillAffectedOnEnemy { get; private set; }
        public double CriticalChance { get; private set; }
        public int Cost { get; private set; }

        private int _skillDamageValue;
        public int SkillDamageValue
        {
            get { return RandomizeDamageValue(_skillDamageValue); }
            private set { _skillDamageValue = value; }
        }
        public int AmountOfValue { get; private set; }
        public IResourceType ResourceType { get; set; } = new Energy();
        public IAttackType Type { get; set; } = new Melee();
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

            if (AmountOfValue < (target.ArmorPoints.Value / 10))
                AmountOfValue = target.ArmorPoints.Value / 10;

            foreach (var debuff in target.Debuffs)
            {
                if (debuff == PlayerDebuff.FindTheWeakness)
                {
                    AmountOfValue *= 120 / 100;
                    break;
                }
            }

            target.ReceiveDamage(AmountOfValue);
            var coolDown = new CoolDownService(this);
            coolDown.Activate();
        }

        public Backstab(int skillLevel)
        {
            SkillName = "Backstab";
            SkillLevel = skillLevel;
            SkillDamageValue = SkillLevel * 5;
            Cost = SkillLevel * 3;
            CoolDownDuration = 3;
        }
    }
}
