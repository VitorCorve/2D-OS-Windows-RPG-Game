using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels;
using System.Windows;

namespace GameOfFrameworks.Infrastructure.Commands.MainWindow
{
    public class SetWindowModeWindowedCommand : Command
    {
        private MainWindowViewModel ViewModel;
        public SetWindowModeWindowedCommand(MainWindowViewModel mainWindowViewModel) => ViewModel = mainWindowViewModel;
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            if (ViewModel.WindowState == WindowState.Normal) ViewModel.WindowState = WindowState.Maximized;
            else ViewModel.WindowState = WindowState.Normal;
        }
    }
}
