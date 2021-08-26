namespace GameEngine.CombatEngine.Interfaces
{
    public interface ISkill
    {
        delegate void CoolDownObserver(ISkill skill);
        event CoolDownObserver NotifyCooldownStart;
        event CoolDownObserver NotifyCooldownEnd;
        int Skill_ID { get; }
        string SkillName { get; }
        int SkillLevel { get; set; }
        int CoolDownDuration { get; set; }
        int CoolDown { get; set; }
        int Cost { get; }
        int AmountOfValue { get; }
        IResourceType ResourceType { get; set; }
        IUseType Type { get; set; }
        void Use(int dealerAttackPower, PlayerEntity target);
        void CoolDownEnd();
    }
}
