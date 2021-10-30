using GameEngine.CombatEngine.Actions;
using GameOfFrameworks.Models.Services.Interfaces;

namespace GameOfFrameworks.Models.Services
{
    public class ActionTypeView : IActionTypeView
    {
        public ACTION_TYPE Action { get; set; }
        public string ImagePresentationPath { get; set; }
    }
}
