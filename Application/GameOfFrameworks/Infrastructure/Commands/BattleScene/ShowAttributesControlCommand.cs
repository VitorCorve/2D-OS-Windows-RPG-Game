using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.BattleScene.Services;
using GameOfFrameworks.ViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.BattleScene
{
    public class ShowAttributesControlCommand : Command
    {
        private readonly BattleWindowViewModel ViewModel;
        public ShowAttributesControlCommand(BattleWindowViewModel battleWindowViewModel) => ViewModel = battleWindowViewModel;

        public override bool CanExecute(object parameter)
        {
            var characterPreviewBarAnimationManager = (CharacterPreviewBarAnimationManager)parameter;
            if (characterPreviewBarAnimationManager.AnimationInProcess) return false;
            return true;
        }

        public override void Execute(object parameter)
        {
            var characterPreviewBarAnimationManager = (CharacterPreviewBarAnimationManager)parameter;
            characterPreviewBarAnimationManager.ShowControl();
        }
    }
}
