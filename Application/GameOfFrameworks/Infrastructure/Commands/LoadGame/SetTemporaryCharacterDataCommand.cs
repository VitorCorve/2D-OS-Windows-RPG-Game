using GameEngine.Equipment;
using GameEngine.Inventory;
using GameEngine.Player;
using GameOfFrameworks.Infrastructure.Commands.Base;
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
            ArmoryTemporaryData.CurrentLocation = new GameEngine.Locations.Location();
            ArmoryTemporaryData.CurrentLocation.Town = Model.SaveData.CurrentTown;
            ArmoryTemporaryData.CharacterEntity = Model.CharacterEntity;
            ArmoryTemporaryData.PlayerModel = new PlayerModelData(Model.SaveData);
            ArmoryTemporaryData.SaveData = Model.SaveData;
            ArmoryTemporaryData.PlayerAttributes = Model.SaveData.PlayerAttributes;
            ArmoryTemporaryData.PlayerEquipment = wearedEquipment;
            ArmoryTemporaryData.PlayerInventory = playerInventoryItemsList;
            ArmoryTemporaryData.PlayerSkills = Model.SaveData.PlayerSkills;
        }
    }
}
