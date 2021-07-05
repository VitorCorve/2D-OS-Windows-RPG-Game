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
    public class Fireball : ISkill
    {
        public string SkillName { get ; private set; }
        public uint SkillLevel { get ; private set; }
        public Timer CoolDownTimer { get ; private set; }
        public Timer DurationTimer { get ; private set; }
        public uint Duration { get ; private set; }
        public uint CoolDown { get; private set; }
        public bool ReadyToUse { get ; private set; }
        public bool SkillAffectedOnEnemy { get ; private set; }
        public uint Cost { get ; private set; }
        public IResourceType ResourceType { get; set; } = new Mana();
        public IAttackType Type { get; set; } = new Magic();
        public uint DamageValue { get; private set; }

        public void Use(PlayerEntity target)
        {
            target.ReceiveDamage(DamageValue + target.AttackPower);
        }

        public Fireball(uint skillLevel)
        {
            SkillName = "Fireball";
            SkillLevel = skillLevel;
            DamageValue = SkillLevel * 5;
            Cost = SkillLevel * 3;
        }

    }
}
