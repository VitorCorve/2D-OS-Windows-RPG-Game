using GameEngine.CombatEngine;
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
    public class RegularAttack : ISkill
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
        public uint DamageValue { get; private set; }
        public IResourceType ResourceType { get; set; } = new Energy();

        public void Use(PlayerEntity target)
        {
            target.ReceiveDamage(DamageValue + target.AttackPower);
        }
    }
}
