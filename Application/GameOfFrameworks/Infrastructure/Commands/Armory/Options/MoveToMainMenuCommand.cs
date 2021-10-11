using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.Scenes;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Options
{
    public class MoveToMainMenuCommand : Command
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            RunGame runGame = new RunGame();
            ArmoryTemporaryData.Instance.NavigationService.Navigate(runGame);
        }
    }
}
