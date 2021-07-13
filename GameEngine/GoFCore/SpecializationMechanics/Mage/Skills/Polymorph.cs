using GameEngine.CombatEngine;
using GameEngine.CombatEngine.ActionTypes;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Services;
using GameEngine.Player.ConditionResources;
using System.Timers;

namespace GameEngine.SpecializationMechanics.Mage.Skills
{
    public class Polymorph : IDebuffSkill
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
        public int SkillDamageValue { get; set; }
        public int AmountOfValue { get; private set; }
        public IResourceType ResourceType { get; set; } = new Mana();
        public IAttackType Type { get; set; } = new Magic();
        public IResourceType ValueType { get; set; }

        public int RandomizeDamageValue(int damageValue)
        {
            return damageValue;
        }
        public void Use(int dealerAttackPower, PlayerEntity target)
        {
            var buffService = new BuffsService(this, target);
            var coolDown = new CoolDownService(this);
            buffService.Activate(() => target.LoseControl());
            coolDown.Activate();
        }

        public Polymorph(int skillLevel)
        {
            SkillName = "Polymorph";
            SkillLevel = skillLevel;
            Cost = SkillLevel * 3;
            CoolDownDuration = 30;
            Duration = 6;
        }

    }
}
