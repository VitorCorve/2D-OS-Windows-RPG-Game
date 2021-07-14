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
        public string SkillName { get; private set; }
        public int SkillLevel { get; private set; }
        public int Duration { get; set; }
        public int CoolDownDuration { get; set; }
        public int CoolDown { get; set; }
        public double CriticalChance { get; private set; }
        public int Cost { get; private set; }
        public int Intervals { get; private set; }
        public int SkillDamageValue { get; set; }
        public int AmountOfValue { get; private set; }
        public IResourceType ResourceType { get; set; } = new Energy();
        public IUseType Type { get; set; } = new Melee();

        public void Use(int dealerAttackPower, PlayerEntity target)
        {
            CriticalChance = target.CriticalHitChance;
            AmountOfValue += (dealerAttackPower + SkillDamageValue) - target.ArmorPoints.Value;

            var damageOverTimeService = new DamageOverTimeService(target, this);
            var coolDown = new CoolDownService(this);

            damageOverTimeService.Activate();
            coolDown.Activate();
        }

        public Rend(int skillLevel)
        {
            SkillName = "Rend";
            SkillLevel = skillLevel;
            AmountOfValue = SkillLevel * 5;
            Cost = SkillLevel * 3;
            CoolDownDuration = 12;
            Duration = 6;
            Intervals = 1;
        }
    }
}
