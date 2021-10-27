using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces;
using GameOfFrameworks.ViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.BattleScene
{
    public class SelectSkillFromSelectedSkillEffectCommand : Command
    {
        private readonly BattleWindowViewModel ViewModel;
        public SelectSkillFromSelectedSkillEffectCommand(BattleWindowViewModel battleWindowViewModel) => ViewModel = battleWindowViewModel;
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            ViewModel.SelectedSkill = (ISkillView)parameter;
            ViewModel.SkillDescriptionVisibility = System.Windows.Visibility.Visible;
        }
    }
}
