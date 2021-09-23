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
        public bool CanExecute(object parameter)
        {
            if (ViewModel.PlayerConsumables.SkillPointsValue.Value > 0)
            {
                return true;
            }
            return false;

        }
        public void Execute(object parameter)
        {
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

            ViewModel.AvailableSkills = null;
            ViewModel.SelectedSkill = null;
            ViewModel.SelectedSkill = selectedSkill;
            ViewModel.AvailableSkills = skillViewList;

            ArmoryTemporaryData.PlayerSkills.Skills = skillViewToSkillConverter.ConvertRange(ViewModel.AvailableSkills);
            ViewModel.AvailableSkillPoints--;
            ViewModel.PlayerConsumables.SkillPointsValue.Value--;

            ArmoryTemporaryData.AvailableSkills = ViewModel.AvailableSkills;
            ArmoryTemporaryData.IsPlayerSkillsUpdated = true;
        }
    }
}
