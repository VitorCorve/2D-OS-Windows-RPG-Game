using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels.Options;
using System.Windows;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Options
{
    public class HideLeaveGameConfirmationControlCommand : Command
    {
        private OptionsControlViewModel ViewModel;
        public HideLeaveGameConfirmationControlCommand(OptionsControlViewModel optionsControlViewModel) => ViewModel = optionsControlViewModel;
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            ViewModel.LeaveGameConfirmationControlVisibility = Visibility.Hidden;
            ViewModel.TemporaryCommand = null;
        }
    }
}
