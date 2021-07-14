using System.Timers;

namespace GameEngine.CombatEngine.Interfaces
{
    public interface ISkill
    {
        string SkillName { get; }
        int SkillLevel { get; }
        int CoolDownDuration { get; set; }
        int CoolDown { get; set; }
        int Cost { get; }
        int AmountOfValue { get; }
        IResourceType ResourceType { get; set; }
        IUseType Type { get; set; }
        void Use(int dealerAttackPower, PlayerEntity target);
    }
}
