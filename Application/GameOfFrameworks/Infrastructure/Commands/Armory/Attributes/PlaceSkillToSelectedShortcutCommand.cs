using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Attributes
{
    public class PlaceSkillToSelectedShortcutCommand : Command
    {
        public AttributesControlViewModel ViewModel { get; }
        public PlaceSkillToSelectedShortcutCommand(AttributesControlViewModel attributesControlViewModel) => ViewModel = attributesControlViewModel;
        public override bool CanExecute(object parameter)
        {
            if (ViewModel.MouseCapturedShortCutIndex < 0) return false;
            return true;
        }
        public override void Execute(object parameter)
        {
            ViewModel.Shortcuts.SkillViewList[ViewModel.MouseCapturedShortCutIndex] = ViewModel.MouseCapturedSkill;
            ViewModel.MouseCapturedSkill = null;
            ViewModel.PopupShortcutIsOpen = false;
        }
    }
}
