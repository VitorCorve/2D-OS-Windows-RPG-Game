using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels.Options;
using System.Windows;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Options
{
    public class HideSaveDeletingControlCommand : Command
    {
        private readonly OptionsControlViewModel ViewModel;
        public HideSaveDeletingControlCommand(OptionsControlViewModel optionsControlViewModel) => ViewModel = optionsControlViewModel;
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter) => ViewModel.DeletingControlVisibility = Visibility.Hidden;
    }
}
