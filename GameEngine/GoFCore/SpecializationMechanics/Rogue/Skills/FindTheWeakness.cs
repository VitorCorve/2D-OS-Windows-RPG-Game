using GameEngine.CombatEngine;
using GameEngine.CombatEngine.ActionTypes;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Services;
using GameEngine.Player.ConditionResources;
using GameEngine.Player.PlayerConditions;
using System;

namespace GameEngine.SpecializationMechanics.Rogue.Skills
{
    public class FindTheWeakness : IDebuffSkill
    {
        public string SkillName { get; private set; } = "Find the weakness";
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
        public int Duration { get; set; } = 12;
        public int CoolDownDuration { get; set; } = 20;
        public int CoolDown { get; set; }
        public int Cost { get; private set; }
        public int AmountOfValue { get; private set; }
        public IResourceType ResourceType { get; set; } = new Mana();
        public IUseType Type { get; set; } = new Magic();

        public void Use(int dealerAttackPower, PlayerEntity target)
        {
            Random chanceOfLethalDamage = new Random();

            if (chanceOfLethalDamage.Next(0, 100) < 10)
                target.ReceivePercentOfDamage(90, SkillName);

            var buffService = new BuffsService(this, target);
            var coolDown = new CoolDownService(this);

            buffService.Activate(() => target.ReceiveDebuff(PLAYER_DEBUFF.FindTheWeakness));
            coolDown.Activate();
        }
        private void ConvertValues()
        {
            Cost = SkillLevel * 3;
            AmountOfValue = SkillLevel * 5;
        }
    }
}
