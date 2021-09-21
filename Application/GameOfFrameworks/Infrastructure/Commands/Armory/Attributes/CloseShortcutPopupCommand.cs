using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Attributes
{
    public class CloseShortcutPopupCommand : Command
    {
        public AttributesControlViewModel ViewModel { get; }
        public CloseShortcutPopupCommand(AttributesControlViewModel attributesControlViewModel) => ViewModel = attributesControlViewModel;
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter) => ViewModel.PopupShortcutIsOpen = false;
    }
}
