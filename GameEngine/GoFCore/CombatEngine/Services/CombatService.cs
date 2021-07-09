using GameEngine.CombatEngine.Actions;
using GameEngine.CombatEngine.Interfaces;

namespace GameEngine.CombatEngine
{
    public class CombatServiсe : IWeaponAttack
    {
        public delegate void NotifyMaster(string message);
        public event NotifyMaster LogDamage;
        public event NotifyMaster LogBuff;
        public event NotifyMaster LogDebuff;
        public delegate void ExecuteAction();
        public delegate bool CheckAction();
        public int DamageValue { get; private set; }
        public CombatServiсe(PlayerEntity dealer)
        {
            DamageValue = dealer.AttackPower;
        }

        public void Execute(PlayerEntity target)
        {
            target.ReceiveDamage(DamageValue - target.ArmorPoints.Value);
        }
        public void Execute(PlayerEntity target, ISkill skill)
        {
            skill.Use(DamageValue, target);

            switch (skill)
            {
                case IDamageSkill:
                    LogDamage($"deals {skill.AmountOfDamage} damage by {skill.SkillName}");
                    return;
                case IBuffSkill:
                    LogBuff($"uses {skill.SkillName} for {skill.AmountOfDamage} value");
                    return;
                case IDebuffSkill:
                    LogDebuff($"uses {skill.SkillName} for {skill.Duration} second");
                    return;
                default:
                    return;
            }

        }
    }
}
