using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Attributes
{
    public class CancelShortcutFocusCommand : Command
    {
        public AttributesControlViewModel ViewModel { get; }
        public CancelShortcutFocusCommand(AttributesControlViewModel attributesControlViewModel) => ViewModel = attributesControlViewModel;

        public override bool CanExecute(object parameter)
        {
            if (ViewModel.MouseCapturedShortCutIndex != -1)
            {
                return true;
            }
            return false;
        }
        public override void Execute(object parameter) => ViewModel.MouseCapturedShortCutIndex = -1;
    }
}
