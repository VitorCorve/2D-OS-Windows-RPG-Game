using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.ApplyCharacterCreation
{
    public class SelectSkill5Command : Command
    {
        public ApplyCharacterCreationViewModel ViewModel { get; set; }
        public SelectSkill5Command(ApplyCharacterCreationViewModel applyCharacterCreationViewModel) => ViewModel = applyCharacterCreationViewModel;
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            ViewModel.SelectedSkill = ViewModel.SkillViewList[4];
            ViewModel.SelectedSkillDescription = ViewModel.SelectedSkill.Description;
            ViewModel.OnPropertyChanged(nameof(ViewModel.SelectedSkill));
            ViewModel.OnPropertyChanged(nameof(ViewModel.SelectedSkillDescription));
        }
    }
}
