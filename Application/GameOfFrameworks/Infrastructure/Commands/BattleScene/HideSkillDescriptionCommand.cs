using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.BattleScene
{
    public class HideSkillDescriptionCommand : Command
    {
        private readonly BattleWindowViewModel ViewModel;
        public HideSkillDescriptionCommand(BattleWindowViewModel battleWindowViewModel) => ViewModel = battleWindowViewModel;
        public override bool CanExecute(object parameter) => ViewModel.SkillDescriptionVisibility == System.Windows.Visibility.Visible;
        public override void Execute(object parameter) => ViewModel.SkillDescriptionVisibility = System.Windows.Visibility.Hidden;
    }
}
