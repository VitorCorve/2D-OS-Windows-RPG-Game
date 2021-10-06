using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.LevelUp
{
    public class UpdateAttributesViewModelAvailableSkillsCommand : Command
    {
        public AttributesControlViewModel ViewModel { get; set; }
        public UpdateAttributesViewModelAvailableSkillsCommand(AttributesControlViewModel attributesControlViewModel) => ViewModel = attributesControlViewModel;
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            ViewModel.AvailableSkills = null;
            ViewModel.AvailableSkills = ArmoryTemporaryData.AvailableSkills;
        }
    }
}
