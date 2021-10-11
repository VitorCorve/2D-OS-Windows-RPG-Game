using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels.Options;
using System.Windows;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Options
{
    public class ShowConfirmMoveToMainMenuControlCommand : Command
    {
        private OptionsControlViewModel ViewModel;
        public ShowConfirmMoveToMainMenuControlCommand(OptionsControlViewModel optionsControlViewModel) => ViewModel = optionsControlViewModel;
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            ViewModel.LeaveGameConfirmationControlVisibility = Visibility.Visible;
            ViewModel.TemporaryCommand = new MoveToMainMenuCommand();
        }
    }
}
