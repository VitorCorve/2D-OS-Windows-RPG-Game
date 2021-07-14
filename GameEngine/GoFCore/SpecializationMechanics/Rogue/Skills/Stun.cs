using GameEngine.CombatEngine;
using GameEngine.CombatEngine.ActionTypes;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Services;
using GameEngine.Player.ConditionResources;

namespace GameEngine.SpecializationMechanics.Rogue.Skills
{
    public class Stun : IDebuffSkill
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

        public void Use(int dealerAttackPower, PlayerEntity target)
        {
            var buffService = new BuffsService(this, target);
            var coolDown = new CoolDownService(this);
            buffService.Activate(() => target.LoseControl());
            coolDown.Activate();
        }

        public Stun(int skillLevel)
        {
            SkillName = "Stun";
            SkillLevel = skillLevel;
            Cost = SkillLevel * 3;
            CoolDownDuration = 10;
            Duration = 4;
        }

    }
}

