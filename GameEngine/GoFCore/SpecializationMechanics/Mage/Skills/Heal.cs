using GameEngine.CombatEngine;
using GameEngine.CombatEngine.ActionTypes;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.Player.ConditionResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace GameEngine.SpecializationMechanics.Mage.Skills
{
    public class Heal : IBuffSkill
    {

        public string SkillName { get; private set; }
        public uint SkillLevel { get; private set; }
        public Timer CoolDownTimer { get; private set; }
        public Timer DurationTimer { get; private set; }
        public uint Duration { get; private set; }
        public uint CoolDown { get; private set; }
        public bool ReadyToUse { get; private set; }
        public bool SkillAffectedOnEnemy { get; private set; }
        public uint Cost { get; private set; }
        public IResourceType ResourceType { get; set; } = new Mana();
        public IAttackType Type { get; set; } = new Magic();
        public uint SkillDamageValue { get; private set; }
        public IValueType ValueType { get; set; }

        public void Use(uint dealerAttackPower, PlayerEntity target)
        {
            target.ReceiveHeal(dealerAttackPower + SkillDamageValue);
        }

        public Heal(uint skillLevel)
        {
            SkillName = "Heal";
            SkillLevel = skillLevel;
            SkillDamageValue = SkillLevel * 5;
            Cost = SkillLevel * 3;
        }

    }
}
