using GameEngine.CombatEngine.Interfaces;
using GameEngine.Player;

namespace GameEngine.LevelUpMechanics.Interfaces.Services
{
    public interface ISkillLevelUpService
    {
        PlayerConsumablesData PlayerConsumables { get; }
        GetAvailablePlayerSkills AvailablePlayerSkills { get; }
        ISkill SkillToRaise { get; }
        void LevelUp();
        void Select();
    }
}
