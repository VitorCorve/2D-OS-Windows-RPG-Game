using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.MainWindow
{
    public class SelectPreviousWindowModeCommand : Command
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter) => MainWindowViewModel.Settings.WindowStyle.SetPreviousWindowStyle();
    }
}
