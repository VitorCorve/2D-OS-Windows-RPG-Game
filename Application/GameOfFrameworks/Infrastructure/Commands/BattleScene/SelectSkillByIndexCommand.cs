using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.BattleScene
{
    public class SelectSkillByIndexCommand : Command
    {
        private readonly BattleWindowViewModel ViewModel;
        public SelectSkillByIndexCommand(BattleWindowViewModel battleWindowViewModel) => ViewModel = battleWindowViewModel;
        public override bool CanExecute(object parameter) => parameter != null;
        public override void Execute(object parameter)
        {
            var selectedSkillIndex = int.Parse((string)parameter);
            ViewModel.SelectedSkill = ViewModel.SkillShortcuts.SkillViewList[selectedSkillIndex];
            ViewModel.SkillDescriptionVisibility = System.Windows.Visibility.Visible;
        }
    }
}
