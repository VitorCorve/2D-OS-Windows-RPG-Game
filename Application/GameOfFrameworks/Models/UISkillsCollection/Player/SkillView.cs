using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Interfaces.SkillMechanics;
using GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces;

namespace GameOfFrameworks.Models.UISkillsCollection.Player
{
    public class SkillView : ISkillView
    {
        private ISkill _Skill;
        public ISkill Skill { get => _Skill; set { _Skill = value; CheckIsISkillDuration(); } }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public double Opacity { get; private set; }
        public bool LevelUpReady { get; private set; }
        public int PlayerLevel { get; set; }
        public string Duration { get; private set; }
        private void CheckIsISkillDuration()
        {
            if (Skill is ISkillDuration duration)
            {
                Duration = "Duration: " + duration.Duration.ToString();
            }
        }
        public void CheckIsLevelUpReady()
        {
            if (PlayerLevel >= Skill.AvailableAtLevel)
            {
                LevelUpReady = true;
                Opacity = 1.0;
            }
            else
            {
                Opacity = 0.4;
                LevelUpReady = false;
            }
        }
        public void Disable()
        {
            Opacity = 0.4;
            LevelUpReady = false;
        }
    }
}
