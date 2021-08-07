using GameEngine.CombatEngine.Interfaces;
using GameEngine.Player;

namespace GameEngine.LevelUpMechanics.Interfaces.Services
{
    public interface ISkillLevelUpService
    {
        int MaxSelectValue { get; }
        int SelectValue { get; }
        PlayerConsumablesData PlayerConsumables { get; }
        GetAvailablePlayerSkills AvailablePlayerSkills { get; }
        ISkill SkillToRaise { get; }
        void LevelUp();
        void Select();
        void LearnDirectly(ISkill skill);
    }
}
