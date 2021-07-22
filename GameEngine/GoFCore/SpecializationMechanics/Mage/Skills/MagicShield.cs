using GameEngine.CombatEngine;
using GameEngine.CombatEngine.ActionTypes;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Interfaces.SkillMechanics;
using GameEngine.CombatEngine.Services;
using GameEngine.Player.ConditionResources;

namespace GameEngine.SpecializationMechanics.Mage.Skills
{
    public class MagicShield : IBuffSkill
    {
        public string SkillName { get; private set; } = "Magic Shield";
        public int SkillLevel
        {
            get { return _SkillLevel; }
            set
            {
                _SkillLevel = value;
                ConvertValues();
            }
        }
        private int _SkillLevel;
        public int Duration { get; set; } = 6;
        public int CoolDownDuration { get; set; } = 10;
        public int CoolDown { get; set; }
        public int Cost { get; private set; }
        public int AmountOfValue { get; private set; }
        public IResourceType ResourceType { get; set; } = new Mana();
        public IUseType Type { get; set; } = new Magic();
        public IResourceType BuffResourceType { get; set; } = new Armor();

        public void Use(int dealerAttackPower, PlayerEntity target)
        {
            AmountOfValue += dealerAttackPower;

            var buffService = new BuffsService(this, target);

            buffService.Activate();

            var coolDown = new CoolDownService(this);
            coolDown.Activate();
        }
        private void ConvertValues()
        {
            Cost = SkillLevel * 3;
            AmountOfValue = SkillLevel * 5;
        }
    }
}
