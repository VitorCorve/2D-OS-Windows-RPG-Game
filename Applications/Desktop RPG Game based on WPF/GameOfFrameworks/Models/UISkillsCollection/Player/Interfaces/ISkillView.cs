using GameEngine.CombatEngine.Interfaces;

namespace GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces
{
    public interface ISkillView
    {
        ISkill Skill { get; }
        string ImagePath { get; }
        string Description { get; }
    }
}
