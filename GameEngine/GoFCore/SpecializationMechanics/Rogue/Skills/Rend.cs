using GameEngine.CombatEngine;
using GameEngine.CombatEngine.ActionTypes;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Interfaces.SkillMechanics;
using GameEngine.CombatEngine.Services;
using GameEngine.Player.ConditionResources;


namespace GameEngine.SpecializationMechanics.Rogue.Skills
{
    public class Rend : IDamageOverTimeSkill, IDamageOverTimeIntervals
    {
        public string SkillName { get; private set; } = "Rend";
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
        public int Duration { get; set; } = 6;
        public int CoolDownDuration { get; set; } = 12;
        public int CoolDown { get; set; }
        public CriticalHitChance CriticalChance { get; private set; }
        public int Intervals { get; private set; } = 1;
        public int SkillDamageValue { get; set; }
        public int AmountOfValue { get; set; }
        public int Cost { get; set; }

        public IResourceType ResourceType { get; set; } = new Energy();
        public IUseType Type { get; set; } = new Melee();

        public void Use(int dealerAttackPower, PlayerEntity target)
        {
            CriticalChance = target.CriticalChance;
            double incomingDamage = ((dealerAttackPower + SkillDamageValue) - target.ArmorPoints.Value) * target.Defense.IncomingDamageDivider;
            AmountOfValue = (int)incomingDamage;

            var damageOverTimeService = new DamageOverTimeService(target, this);
            var coolDown = new CoolDownService(this);

            damageOverTimeService.Activate();
            coolDown.Activate();
        }
        private void ConvertValues()
        {
            Cost = SkillLevel * 3;
            SkillDamageValue = SkillLevel * 5;
        }
    }
}
