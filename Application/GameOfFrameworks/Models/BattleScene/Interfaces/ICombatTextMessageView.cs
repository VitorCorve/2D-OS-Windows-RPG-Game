
namespace GameOfFrameworks.Models.BattleScene.Interfaces
{
    public interface ICombatTextMessageView
    {
        string Message { get; set; }
        string ActionImageView { get; set; }
        string SkillUseImageView { get; set; }
        string Time { get; set; }
    }
}
