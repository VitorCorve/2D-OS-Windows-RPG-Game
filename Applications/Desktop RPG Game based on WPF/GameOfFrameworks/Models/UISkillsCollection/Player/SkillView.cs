using GameEngine.CombatEngine.Interfaces;
using GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces;

namespace GameOfFrameworks.Models.UISkillsCollection.Player
{
    public class SkillView : ISkillView
    {
        public ISkill Skill { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
    }
}
