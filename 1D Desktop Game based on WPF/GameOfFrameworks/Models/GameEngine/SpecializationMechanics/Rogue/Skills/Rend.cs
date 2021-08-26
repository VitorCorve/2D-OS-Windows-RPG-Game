using GameEngine.CombatEngine;
using GameEngine.CombatEngine.ActionTypes;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Interfaces.SkillMechanics;
using GameEngine.CombatEngine.Services;
using GameEngine.Player.ConditionResources;
using static GameEngine.CombatEngine.Interfaces.ISkill;

namespace GameEngine.SpecializationMechanics.Rogue.Skills
{
    public class Rend : IDamageOverTimeSkill, IDamageOverTimeIntervals
    {
        public event CoolDownObserver NotifyCooldownStart;
        public event CoolDownObserver NotifyCooldownEnd;
        public event CoolDownObserver NotifyHarmEffectAppears;
        public event CoolDownObserver NotifyHarmEffectFade;
        public int Skill_ID { get; } = 10;
        public string SkillName { get; private set; } = "Rend";
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
        public int ActiveDuration { get; set; }
        public int CoolDownDuration { get; set; } = 12;
        public int CoolDown { get; set; }
        public CriticalHitChance CriticalChance { get; private set; }
        public int Intervals { get; private set; } = 1;
        public int SkillDamageValue { get; set; }
        public int AmountOfValue { get; set; }
        public int Cost { get; set; }

        public IResourceType ResourceType { get; set; } = new Energy();
        public IUseType Type { get; set; } = new Melee();

        public void Use(int dealerAttackPower, PlayerEntity target)
        {
            CriticalChance = target.CriticalChance;
            double incomingDamage = ((dealerAttackPower + SkillDamageValue) - target.ArmorPoints.Value) * target.Defense.IncomingDamageDivider;
            AmountOfValue = (int)incomingDamage;

            var damageOverTimeService = new DamageOverTimeService(target, this);
            var coolDown = new CoolDownService(this);

            damageOverTimeService.Activate();
            coolDown.Activate();

            NotifyHarmEffectAppears?.Invoke(this);
            NotifyCooldownStart?.Invoke(this);
        }
        private void ConvertValues()
        {
            Cost = SkillLevel * 3;
            SkillDamageValue = SkillLevel * 5;
        }
        public void CoolDownEnd()
        {
            NotifyCooldownEnd?.Invoke(this);
        }
        public void HarmEffectEnd()
        {
            NotifyHarmEffectFade?.Invoke(this);
        }
    }
}
