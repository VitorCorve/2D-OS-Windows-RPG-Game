using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Attributes
{
    public class SelectItemFromSkillViewListCommand : Command
    {
        public AttributesControlViewModel ViewModel { get; }
        public SelectItemFromSkillViewListCommand(AttributesControlViewModel attributesControlViewModel) => ViewModel = attributesControlViewModel;
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            ViewModel.MouseCapturedSkill = ViewModel.SelectedSkill;
            ViewModel.PopupShortcutIsOpen = true;
        }
    }
}
