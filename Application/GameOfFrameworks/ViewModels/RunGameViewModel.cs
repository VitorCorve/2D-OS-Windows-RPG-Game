using GameOfFrameworks.Infrastructure.Commands.MainMenu;
using GameOfFrameworks.ViewModels.Base;
using System.Windows.Input;

namespace GameOfFrameworks.ViewModels
{
    public class RunGameViewModel : ViewModel
    {
        public ICommand ExitGameCommand { get; }
        public RunGameViewModel()
        {
            ExitGameCommand = new ExitGameCommand();
        }
    }
}
