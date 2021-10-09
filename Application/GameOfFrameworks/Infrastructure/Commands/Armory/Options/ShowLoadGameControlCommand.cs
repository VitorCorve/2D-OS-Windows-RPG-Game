using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels.Options;
using System.Windows;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Options
{
    public class ShowLoadGameControlCommand : Command
    {
        private readonly OptionsControlViewModel ViewModel;
        public ShowLoadGameControlCommand(OptionsControlViewModel optionsControlViewModel) => ViewModel = optionsControlViewModel;
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            ViewModel.HideControls();
            ViewModel.LoadGameControlVisibility = Visibility.Visible;
        }
    }
}
