using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.BattleScene
{
    public class BackToArmoryCommand : Command
    {
        private readonly BattleWindowViewModel ViewModel;
        public BackToArmoryCommand(BattleWindowViewModel battleWindowViewModel) => ViewModel = battleWindowViewModel;
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            ViewModel.StopFight();
            ArmoryTemporaryData.CharacterEntity = ViewModel.GetPlayerEntity();
            BattleWindowTemporaryData.Instance.NavigationService.Navigate(new GameOfFrameworks.Scenes.Armory());
            BattleWindowTemporaryData.IsActive = false;
        }
    }
}
