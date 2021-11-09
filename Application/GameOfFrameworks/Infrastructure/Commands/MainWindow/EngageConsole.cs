using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.MainWindow
{
    public class EngageConsole : Command
    {
        private readonly MainWindowViewModel ViewModel;
        public EngageConsole(MainWindowViewModel mainWindowViewModel) => ViewModel = mainWindowViewModel;
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            if (ArmoryTemporaryData.Console is null) return;
            if (ViewModel.ConsoleVisibility == System.Windows.Visibility.Hidden)
            {
                ViewModel.ConsoleVisibility = System.Windows.Visibility.Visible;
                ViewModel.IsConsoleTextBoxFocused = true;
            }
            else
            {
                ViewModel.ConsoleVisibility = System.Windows.Visibility.Hidden;
                ViewModel.IsConsoleTextBoxFocused = false;
                ViewModel.DisengageConsole();
            }
        }
    }
}
