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
    public class DeepDefense : IBuffSkill, ISkillDuration, IBuffSecondResourceType
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
        public IResourceType BuffResourceType { get; set; } = new DefensePower();
        public IResourceType BuffSecondResourceType { get; set; } = new AttackPower();

        public void Use(int dealerAttackPower, PlayerEntity target)
        {
            double buffValue = (10.0 - AmountOfValue) / 10;
            var buffService = new BuffsService(this, target);
            buffService.Activate(() => target.SetValue(BuffResourceType, buffValue));
            buffService.Activate(() => target.SetValue(BuffSecondResourceType, buffValue / 3));

            var coolDown = new CoolDownService(this);
            coolDown.Activate();
        }

        public DeepDefense(int skillLevel)
        {
            AmountOfValue = skillLevel;
            SkillName = "Deep defense";
            SkillLevel = skillLevel;
            Cost = SkillLevel * 2;
            Duration = 20;
            CoolDownDuration = 20;
        }
    }
}
