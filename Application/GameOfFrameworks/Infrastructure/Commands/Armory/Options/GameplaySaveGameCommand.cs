using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels.Options;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Options
{
    public class GameplaySaveGameCommand : Command
    {
        private readonly OptionsControlViewModel ViewModel;
        public GameplaySaveGameCommand(OptionsControlViewModel optionsControlViewModel) => ViewModel = optionsControlViewModel;
        public override bool CanExecute(object parameter)
        {
            if (ViewModel.SavesList.SelectionIndex >= 0) return true;
            else return false;
        }

        public override void Execute(object parameter) => ViewModel.OverwriteControlVisibility = System.Windows.Visibility.Visible;
    }
}
