using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;
using System;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Attributes
{
    public class SetupCapturedSkillToShortcutCommand : Command
    {
        private int SelectedIndex { get; set; }
        public AttributesControlViewModel ViewModel { get; }
        public SetupCapturedSkillToShortcutCommand(AttributesControlViewModel attributesControlViewModel) => ViewModel = attributesControlViewModel;

        public override bool CanExecute(object parameter)
        {
            if (parameter != null)
            {
                SelectedIndex = Int32.Parse((string)parameter);
                ShowSkillDescription(SelectedIndex);
            }
            if (ViewModel.MouseCapturedSkill is null) return false;

            return true;
        }

        public override void Execute(object parameter)
        {
            SelectedIndex = Int32.Parse((string)parameter);
            ViewModel.MouseCapturedShortCutIndex = SelectedIndex;
            ViewModel.Shortcuts.SkillViewList[SelectedIndex] = ViewModel.MouseCapturedSkill;
            ViewModel.MouseCapturedSkill = null;
            ViewModel.SelectedSkill = ViewModel.Shortcuts.SkillViewList[SelectedIndex];
            ArmoryTemporaryData.SkillsShortcuts = ViewModel.Shortcuts;
        }
        private void ShowSkillDescription(int selectedIndex)
        {
            ViewModel.SelectedSkill = ViewModel.Shortcuts.SkillViewList[selectedIndex];
        }
    }
}
