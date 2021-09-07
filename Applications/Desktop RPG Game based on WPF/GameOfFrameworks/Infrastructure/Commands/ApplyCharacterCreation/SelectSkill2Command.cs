using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.ApplyCharacterCreation
{
    public class SelectSkill2Command : Command
    {
        public ApplyCharacterCreationViewModel ViewModel { get; set; }
        public SelectSkill2Command(ApplyCharacterCreationViewModel applyCharacterCreationViewModel) => ViewModel = applyCharacterCreationViewModel;
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            ViewModel.SelectedSkill = ViewModel.SkillViewList[1];
            ViewModel.OnPropertyChanged(nameof(ViewModel.SelectedSkill));
            ViewModel.SelectedSkillDescription = ViewModel.SelectedSkill.Description;
            ViewModel.OnPropertyChanged(nameof(ViewModel.SelectedSkillDescription));
        }
    }
}
