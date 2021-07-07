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

namespace GameEngine.SpecializationMechanics.GlobalSkills
{
    public class RegularAttack : IDamageSkill
    {
        public string SkillName { get; private set; }
        public int SkillLevel { get; private set; }
        public Timer CoolDownTimer { get; private set; }
        public Timer DurationTimer { get; private set; }
        public int Duration { get; private set; }
        public int CoolDown { get; private set; }
        public bool ReadyToUse { get; private set; }
        public bool SkillAffectedOnEnemy { get; private set; }
        public int Cost { get; private set; }
        public int SkillDamageValue { get; private set; }
        public IResourceType ResourceType { get; set; } = new Energy();
        public IAttackType Type { get; set; } = new Melee();
        public IValueType ValueType { get; set; }

        public void Use(int dealerAttackPower, PlayerEntity target)
        {
           target.ReceiveDamage(dealerAttackPower - target.ArmorPoints.Value);
        }
    }
}
