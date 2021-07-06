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
        public uint SkillLevel { get; private set; }
        public Timer CoolDownTimer { get; private set; }
        public uint Duration { get; private set; }
        public uint CoolDown { get; private set; }
        public bool ReadyToUse { get; private set; }
        public bool SkillAffectedOnEnemy { get; private set; }
        public uint Cost { get; private set; }
        public uint SkillDamageValue { get; private set; }
        public IResourceType ResourceType { get; set; } = new Mana();
        public IAttackType Type { get; set; } = new Magic();
        public IValueType ValueType { get; set; } = new Armor();

        public void Use(uint dealerAttackPower, PlayerEntity target)
        {
            uint buffValue = SkillDamageValue + dealerAttackPower;

            var buffService = new BuffsService(this, target, Duration, buffValue, ValueType);

            buffService.Activate();
        }


        public MagicShield(uint skillLevel)
        {
            SkillName = "Magic Shield";
            SkillLevel = skillLevel;
            SkillDamageValue = SkillLevel * 5;
            Duration = 6;
            Cost = SkillLevel * 3;
        }
    }
}
