using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.MainWindow
{
    public class SelectNextWindowModeCommand : Command
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter) => MainWindowViewModel.Settings.WindowStyle.SetNextWindowStyle();
    }
}
