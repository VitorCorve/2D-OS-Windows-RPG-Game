using GameEngine.CombatEngine;
using GameEngine.CombatEngine.ActionTypes;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Services;
using GameEngine.Player.ConditionResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace GameEngine.SpecializationMechanics.Mage.Skills
{
    public class MagicShield : IBuffSkill
    {
        public string SkillName { get; private set; }
        public int SkillLevel { get; private set; }
        public Timer CoolDownTimer { get; private set; }
        public int Duration { get; private set; }
        public int CoolDown { get; private set; }
        public bool ReadyToUse { get; private set; }
        public bool SkillAffectedOnEnemy { get; private set; }
        public int Cost { get; private set; }
        public int SkillDamageValue { get; private set; }
        public int AmountOfDamage { get; private set; }
        public IResourceType ResourceType { get; set; } = new Mana();
        public IAttackType Type { get; set; } = new Magic();
        public IValueType ValueType { get; set; } = new Armor();

        public void Use(int dealerAttackPower, PlayerEntity target)
        {
            int buffValue = SkillDamageValue + dealerAttackPower;

            var buffService = new BuffsService(this, target, Duration, buffValue, ValueType);

            buffService.Activate();
        }


        public MagicShield(int skillLevel)
        {
            SkillName = "Magic Shield";
            SkillLevel = skillLevel;
            SkillDamageValue = SkillLevel * 5;
            Duration = 6;
            Cost = SkillLevel * 3;
        }
    }
}
