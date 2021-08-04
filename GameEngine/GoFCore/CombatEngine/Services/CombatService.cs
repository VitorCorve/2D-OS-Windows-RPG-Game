using GameEngine.CombatEngine.Actions;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Interfaces.SkillMechanics;
using GameEngine.Player.ConditionResources;

namespace GameEngine.CombatEngine
{
    public class CombatServiсe : IWeaponAttack
    {
        public delegate void NotifyMaster(string message);
        public event NotifyMaster LogDamage;
        public event NotifyMaster LogBuff;
        public event NotifyMaster LogDebuff;
        public event NotifyMaster LogDeath;
        public delegate void ExecuteAction();
        public delegate bool CheckAction();
        public AttackPower DamageValue { get; private set; }
        public int OutComingDamage { get; private set; }
        public CombatServiсe(PlayerEntity dealer)
        {
            DamageValue = dealer.Attack;
        }

        public void Execute(PlayerEntity target)
        {
            target.ReceiveDamage(DamageValue.Value - target.ArmorPoints.Value);
        }
        public void Execute(PlayerEntity target, ISkill skill)
        {
            skill.Use(DamageValue.Value, target);

            switch (skill)
            {
                case IDamageSkill:
                    LogDamage($"deals {skill.AmountOfValue} damage by {skill.SkillName}");
                    break;
                case IBuffSkill:
                    LogBuff($"uses {skill.SkillName} for {((IBuffSkill)skill).Duration} second");
                    break;
                case IDebuffSkill:
                    LogDebuff($"uses {skill.SkillName} for {((IDebuffSkill)skill).Duration} second");
                    break;
                case IHealSkill:
                    LogBuff($"recovers {skill.AmountOfValue} health by Heal");
                    break;
                default:
                    break;
            }

            if (target.HealthPoints.Value <= 0)
                LogDeath($"died");
        }
    }
}
