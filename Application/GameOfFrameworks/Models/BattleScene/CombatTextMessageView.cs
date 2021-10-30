using GameOfFrameworks.Models.BattleScene.Interfaces;

namespace GameOfFrameworks.Models.BattleScene
{
    public class CombatTextMessageView : ICombatTextMessageView
    {
        public string Message { get; set; }
        public string ActionImageView { get; set; }
        public string SkillUseImageView { get; set; }
        public string Time { get; set; }
    }
}
