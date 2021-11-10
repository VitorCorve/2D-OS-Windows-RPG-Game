using GameEngine.CombatEngine;
using GameEngine.EquipmentManagement;
using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.Armory.AttributesControl;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.Armory
{
    public class UpdateAttributesViewModelCommand : Command
    {
        public AttributesControlViewModel ViewModel { get; set; }
        public UpdateAttributesViewModelCommand(AttributesControlViewModel attributesControlViewModel) => ViewModel = attributesControlViewModel;
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            var playerEntityConstructor = new PlayerEntityConstructor();
            var equippmentValues = new EquipmentValue(ArmoryTemporaryData.PlayerEquipment);
            var playerEntity = playerEntityConstructor.CreatePlayer(ArmoryTemporaryData.PlayerModel, ArmoryTemporaryData.PlayerAttributes, equippmentValues);

            ViewModel.Attributes = new AttributesModel(playerEntity, ArmoryTemporaryData.PlayerAttributes, equippmentValues);

            ArmoryTemporaryData.CharacterEntity = playerEntity;
            ViewModel.Bindings = MainWindowViewModel.Settings.Bindings;
        }
    }
}
