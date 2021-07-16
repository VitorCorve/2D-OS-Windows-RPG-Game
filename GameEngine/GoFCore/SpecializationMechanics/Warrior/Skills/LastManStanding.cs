using GameEngine.CombatEngine;
using GameEngine.CombatEngine.ActionTypes;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Interfaces.SkillMechanics;
using GameEngine.CombatEngine.Services;
using GameEngine.Player.ConditionResources;
using GameEngine.Player.DefenseResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameEngine.SpecializationMechanics.Warrior.Skills
{
    public class LastManStanding : IBuffSkill, ISkillDuration, IBuffSecondResourceType
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
        public IResourceType BuffResourceType { get; set; } = new AttackPower();
        public IResourceType BuffSecondResourceType { get; set; } = new DefensePower();

        public void Use(int dealerAttackPower, PlayerEntity target)
        {
            var buffService = new BuffsService(this, target);
            buffService.Activate(() => target.SetValue(BuffResourceType, 1.0 + (SkillLevel / 10.0)));
            buffService.Activate(() => target.SetValue(BuffSecondResourceType, 1.2));

            var coolDown = new CoolDownService(this);
            coolDown.Activate();
        }

        public LastManStanding(int skillLevel)
        {
            AmountOfValue = skillLevel;
            SkillName = "Last man standing";
            SkillLevel = skillLevel;
            Cost = SkillLevel * 2;
            Duration = 5;
            CoolDownDuration = 20;
        }
    }
}

