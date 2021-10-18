using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels.Options;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Options
{
    public class HideSavingOverwriteControlCommand : Command
    {
        private readonly OptionsControlViewModel ViewModel;
        public HideSavingOverwriteControlCommand(OptionsControlViewModel optionsControlViewModel) => ViewModel = optionsControlViewModel;
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter) => ViewModel.OverwriteControlVisibility = System.Windows.Visibility.Hidden;
    }
}
