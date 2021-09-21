using GameEngine.CombatEngine;
using GameEngine.Equipment;
using GameEngine.EquipmentManagement;
using GameEngine.Inventory;
using GameEngine.Player;
using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.Armory.AttributesControl;
using GameOfFrameworks.Models.LoadGame;
using GameOfFrameworks.Models.Temporary;

namespace GameOfFrameworks.Infrastructure.Commands.LoadGame
{
    public class SetTemporaryCharacterDataCommand : Command
    {
        public LoadGameModel Model { get; set; }
        public SetTemporaryCharacterDataCommand(LoadGameModel loadGameModel) => Model = loadGameModel;
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            var wearedEquipment = new WearedEquipment(Model.SaveData.ItemsOnCharacter.ConvertToItemsEntityList());
            var playerInventoryItemsList = new PlayerInventoryItemsList(Model.SaveData.ItemsInInventory.ConvertToItemsEntityList());
            ArmoryTemporaryData.CharacterEntity = Model.CharacterEntity;
            ArmoryTemporaryData.PlayerModel = new PlayerModelData(Model.SaveData);
            ArmoryTemporaryData.SaveData = Model.SaveData;
            ArmoryTemporaryData.PlayerEquipment = wearedEquipment;
            ArmoryTemporaryData.PlayerInventory = playerInventoryItemsList;
        }
    }
}
