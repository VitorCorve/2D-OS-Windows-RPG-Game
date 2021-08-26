using GameOfFrameworks.Infrastructure.Commands.Base;
using System.Windows;

namespace GameOfFrameworks.Infrastructure.Commands.MainMenu
{
    public class ExitGameCommand : Command
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter) => Application.Current.Shutdown();
    }
}
