using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces;
using GameOfFrameworks.Models.UISkillsCollection.Player.Services;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;
using System;
using System.Windows.Input;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.LevelUp
{
    public class UpdatePlayerSkillCommand : ICommand
    {
        public LevelUpViewModel ViewModel { get; }
        public event EventHandler CanExecuteChanged;
        public UpdatePlayerSkillCommand(LevelUpViewModel levelUpViewModel) => ViewModel = levelUpViewModel;
        public bool CanExecute(object parameter) => true;
        public void Execute(object parameter)
        {
            if (parameter is null) return;

            var skillToRiseUp = (ISkillView)parameter;

            var skillViewToSkillConverter = new SkillViewToSkillConverter();

            var skillViewList = ViewModel.AvailableSkills;
            var selectedSkill = ViewModel.SelectedSkill;

            foreach (var availableSkill in skillViewList)
            {
                if (skillToRiseUp.Skill.Skill_ID == availableSkill.Skill.Skill_ID)
                {
                    availableSkill.Skill.SkillLevel++;
                    break;
                }
            }
            foreach (var playerSkill in ArmoryTemporaryData.PlayerSkills.Skills)
            {
                if (skillToRiseUp.Skill.Skill_ID == playerSkill.Skill_ID)
                {
                    playerSkill.SkillLevel++;
                    break;
                }
            }

            ViewModel.AvailableSkills = null;
            ViewModel.SelectedSkill = null;
            ViewModel.SelectedSkill = selectedSkill;
            ViewModel.AvailableSkills = skillViewList;

            ArmoryTemporaryData.AvailableSkills = ViewModel.AvailableSkills;
            ViewModel.PlayerConsumables.SkillPointsValue.Value--;

            ArmoryTemporaryData.AvailableSkills = ViewModel.AvailableSkills;
            AttributesControlViewModel.UpdateShortcutsCommand.Execute(null);
            AttributesControlViewModel.UpdateAttributesViewModelAvailableSkillsCommand.Execute(null);
            LevelUpViewModel.UpdateLevelUpViewModelCommand.Execute(null);
        }
    }
}
