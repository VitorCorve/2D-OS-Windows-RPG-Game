using GameEngine.CombatEngine;
using GameEngine.CombatEngine.ActionTypes;
using GameEngine.CombatEngine.Delegates;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Interfaces.SkillMechanics;
using GameEngine.CombatEngine.Services;
using GameEngine.Player.ConditionResources;
using GameEngine.Player.DefenseResources;
using System;

namespace GameEngine.SpecializationMechanics.Warrior.Skills
{
    public class CrushLegs : IDebuffSkill, ISpecialSkill
    {
        public event SpecialAblitiesCallDelegate Buff;
        public event SpecialAbilitiesFadeDelegate BuffFade;
        public string SkillName { get; private set; } = "Crush legs";
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
        public int CoolDownDuration { get; set; } = 10;
        public int CoolDown { get; set; }
        public int Cost { get; private set; }
        public int AmountOfValue { get; private set; }
        public IResourceType ResourceType { get; set; } = new Energy();
        public IUseType Type { get; set; } = new Melee();
        public IResourceType BuffResourceType { get; set; } = new Dodge();
        public IResourceType SpecialResource { get; set; } = new CriticalHitChance();
        public int Duration { get; set; } = 2;

        public void Use(int dealerAttackPower, PlayerEntity target)
        {
            var buffService = new BuffsService(this, target);
            var coolDown = new CoolDownService(this);

            buffService.Activate(() => target.SetValue(BuffResourceType, - 100));
            coolDown.Activate();

            Buff(this, 100);
        }
        public void CancelEffect()
        {
            BuffFade(this);
        }
        private void ConvertValues()
        {
            Cost = SkillLevel * 3;
            AmountOfValue = SkillLevel * 5;
        }
    }
}
