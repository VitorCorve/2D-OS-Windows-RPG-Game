using System.Timers;

namespace GameEngine.CombatEngine.Interfaces
{
    public interface ISkill
    {
        string SkillName { get; }
        int SkillLevel { get; }
        Timer CoolDownTimer { get; }
        int Duration { get; set; }
        int CoolDownDuration { get; set; }
        int CoolDown { get; set; }
        bool ReadyToUse { get; }
        bool SkillAffectedOnEnemy { get; }
        double CriticalChance { get; }
        int Cost { get; }
        int SkillDamageValue { get; }
        int AmountOfValue { get; }
        IResourceType ResourceType { get; set; }
        IAttackType Type { get; set; }
        IResourceType ValueType { get; set; }
        void Use(int dealerAttackPower, PlayerEntity target);
        int RandomizeDamageValue(int damageValue);
    }
}
