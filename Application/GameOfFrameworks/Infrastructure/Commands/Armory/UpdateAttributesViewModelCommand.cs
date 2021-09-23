using GameEngine.CombatEngine;
using GameEngine.EquipmentManagement;
using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.Armory.AttributesControl;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.Armory
{
    public class UpdateAttributesViewModelCommand : Command
    {
        public AttributesControlViewModel ViewModel { get; set; }
        public UpdateAttributesViewModelCommand(AttributesControlViewModel attributesControlViewModel) => ViewModel = attributesControlViewModel;
        public override bool CanExecute(object parameter)
        {
            if (ArmoryTemporaryData.IsPlayerSkillsUpdated)
            {
                UpdateViewModelAvailableSkills();
                ArmoryTemporaryData.IsPlayerSkillsUpdated = false;
            }
            if (ArmoryTemporaryData.IsPlayerAttributesUpdated)
            {
                ArmoryTemporaryData.IsPlayerAttributesUpdated = false;
                return true;
            }
            else return false;
        }
        public override void Execute(object parameter)
        {
            var playerEntityConstructor = new PlayerEntityConstructor();
            var equippmentValues = new EquipmentValue(ArmoryTemporaryData.PlayerEquipment);
            var playerEntity = playerEntityConstructor.CreatePlayer(ArmoryTemporaryData.PlayerModel, ArmoryTemporaryData.PlayerAttributes, equippmentValues);

            ViewModel.Attributes = new AttributesModel(playerEntity, ArmoryTemporaryData.PlayerAttributes, equippmentValues);

            ArmoryTemporaryData.CharacterEntity = playerEntity;
            ArmoryTemporaryData.IsPlayerEntityChanged = true;
        }
        private void UpdateViewModelAvailableSkills()
        {
            ViewModel.AvailableSkills = null;
            ViewModel.AvailableSkills = ArmoryTemporaryData.AvailableSkills;
        }
    }
}
