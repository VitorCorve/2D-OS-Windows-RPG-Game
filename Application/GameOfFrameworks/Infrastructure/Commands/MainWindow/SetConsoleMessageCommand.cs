using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels;
using System.Collections.Generic;

namespace GameOfFrameworks.Infrastructure.Commands.MainWindow
{
    public class SetConsoleMessageCommand : Command
    {
        private readonly MainWindowViewModel ViewModel;
        public SetConsoleMessageCommand(MainWindowViewModel mainWindowViewModel) => ViewModel = mainWindowViewModel;
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter) => ViewModel.ConsoleNotificationsList.AddNewCommandToViewList(new List<string> { (string)parameter });
    }
}
