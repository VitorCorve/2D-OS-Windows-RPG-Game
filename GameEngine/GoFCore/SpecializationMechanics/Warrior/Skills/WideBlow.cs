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
        public string SkillName { get; private set; }
        public int SkillLevel { get; private set; }
        public int Duration { get; set; }
        public int CoolDownDuration { get; set; }
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
            AmountOfValue = (dealerAttackPower + SkillDamageValue) - target.ArmorPoints.Value;

            if (AmountOfValue < (target.ArmorPoints.Value / 10))
                AmountOfValue = target.ArmorPoints.Value / 10;

            var buffService = new BuffsService(this, target);
            var coolDown = new CoolDownService(this);
            coolDown.Activate();

            buffService.Activate(() => target.RecoverResources.StopRecover(BuffResourceType));

            target.ReceiveDamage(AmountOfValue);
        }

        public WideBlow(int skillLevel)
        {
            SkillName = "Wide blow";
            SkillLevel = skillLevel;
            SkillDamageValue = SkillLevel * 10;
            Cost = SkillLevel * 3;
            CoolDownDuration = 15;
            Duration = 8;
        }
    }
}
