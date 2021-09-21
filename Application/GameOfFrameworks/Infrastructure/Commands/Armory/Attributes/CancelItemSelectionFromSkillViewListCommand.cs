using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Attributes
{
    public class CancelItemSelectionFromSkillViewListCommand : Command
    {
        public AttributesControlViewModel ViewModel { get; }
        public CancelItemSelectionFromSkillViewListCommand(AttributesControlViewModel attributesControlViewModel) => ViewModel = attributesControlViewModel;

        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter) => ViewModel.SelectedSkill = null;
    }
}
