using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels.Options;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Options
{
    public class ExecuteTemporaryCommand : Command
    {
        private OptionsControlViewModel ViewModel;
        public ExecuteTemporaryCommand(OptionsControlViewModel optionsControlViewModel) => ViewModel = optionsControlViewModel;
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter) => ViewModel.TemporaryCommand.Execute(null);
    }
}
