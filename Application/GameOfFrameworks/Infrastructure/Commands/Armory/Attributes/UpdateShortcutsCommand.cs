using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Attributes
{
    public class UpdateShortcutsCommand : Command
    {
        private AttributesControlViewModel ViewModel;
        public UpdateShortcutsCommand(AttributesControlViewModel attributesControlViewModel) => ViewModel = attributesControlViewModel;
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            var playerSkills = ArmoryTemporaryData.PlayerSkills.Skills;
            var playerSkillShortcuts = ViewModel.Shortcuts;
            foreach (var skillShortcut in playerSkillShortcuts.SkillViewList)
            {
                foreach (var skill in playerSkills)
                {
                    if (skillShortcut.Skill is null) continue;

                    if (skillShortcut.Skill.SkillName == skill.SkillName)
                    {
                        skillShortcut.Skill.SkillLevel = skill.SkillLevel;
                    }
                }
            }
            ViewModel.Shortcuts = playerSkillShortcuts;
            ViewModel.OnPropertyChanged(nameof(ViewModel.Shortcuts));
        }
    }
}
