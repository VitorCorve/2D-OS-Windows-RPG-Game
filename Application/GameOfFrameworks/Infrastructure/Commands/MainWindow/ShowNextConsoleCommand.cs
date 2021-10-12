using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.MainWindow
{
    public class ShowNextConsoleCommand : Command
    {
        private readonly MainWindowViewModel ViewModel;
        public ShowNextConsoleCommand(MainWindowViewModel mainWindowViewModel) => ViewModel = mainWindowViewModel;
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            ViewModel.ConsoleCommandCount = ViewModel.CommandsList.Commands.Count;

            if (ViewModel.ConsoleCommandSelectionIndex == 0)
            {
                ViewModel.ConsoleCommandSelectionIndex = ViewModel.ConsoleCommandCount - 1;
                ViewModel.ConsoleCommand = ViewModel.CommandsList.Commands[ViewModel.ConsoleCommandSelectionIndex];
            }
            else
            {
                ViewModel.ConsoleCommandSelectionIndex++;
                if (ViewModel.ConsoleCommandSelectionIndex == ViewModel.ConsoleCommandCount)
                {
                    ViewModel.ConsoleCommandSelectionIndex = 0;
                }
                ViewModel.ConsoleCommand = ViewModel.CommandsList.Commands[ViewModel.ConsoleCommandSelectionIndex];
            }
        }
    }
}
