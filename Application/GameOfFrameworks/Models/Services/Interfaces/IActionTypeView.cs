using GameEngine.CombatEngine.Actions;

namespace GameOfFrameworks.Models.Services.Interfaces
{
    public interface IActionTypeView
    {
        ACTION_TYPE Action { get; }
        string ImagePresentationPath { get; }
    }
}
