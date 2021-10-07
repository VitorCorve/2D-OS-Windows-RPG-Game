using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.Models.UISkillsCollection.Player.Services;
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
            var skillToSkillViewConverter = new SkillToSkillViewConverter(ArmoryTemporaryData.PlayerModel.Specialization);

            ViewModel.AvailableSkills = null;
            ViewModel.AvailableSkills = skillToSkillViewConverter.ConvertRangeToObservableCollection(ArmoryTemporaryData.PlayerSkills.Skills);
        }
    }
}
