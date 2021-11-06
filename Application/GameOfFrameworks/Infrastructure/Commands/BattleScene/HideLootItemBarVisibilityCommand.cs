using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.BattleScene
{
    public class HideLootItemBarVisibilityCommand : Command
    {
        private readonly BattleWindowViewModel ViewModel;
        public HideLootItemBarVisibilityCommand(BattleWindowViewModel battleWindowViewModel) => ViewModel = battleWindowViewModel;
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter) => ViewModel.LootItemBarVisibility = System.Windows.Visibility.Hidden;
    }
}
