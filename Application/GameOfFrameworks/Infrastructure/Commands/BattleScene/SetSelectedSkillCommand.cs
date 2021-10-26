using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces;
using GameOfFrameworks.ViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.BattleScene
{
    public class SetSelectedSkillCommand : Command
    {
        private readonly BattleWindowViewModel ViewModel;
        public SetSelectedSkillCommand(BattleWindowViewModel battleWindowViewModel) => ViewModel = battleWindowViewModel;
        public override bool CanExecute(object parameter) => parameter != null;
        public override void Execute(object parameter)
        {
            var selectedSkill = (ISkillView)parameter;
            ViewModel.SelectedSkill = selectedSkill;
            ViewModel.SkillDescriptionVisibility = System.Windows.Visibility.Visible;
        }
    }
}
