using GameEngine.Equipment;
using GameEngine.Inventory;
using GameOfFrameworks.Models.UISkillsCollection.Player;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;

namespace GameOfFrameworks.Models.Services.Interfaces
{
    public interface IEquipmentManager
    {
        EquipmentControlViewModel ViewModel { get; }
        WearedEquipment EquipmentWearedModel { get; }
        PlayerInventoryItemsList InventoryItemsModel { get; }
        ItemEntityConverter Converter { get; }
        void WearItemFromInventory(EquipmentUserInterfaceViewTemplate viewTemplate);
        void TakeOffEquippedItem(EquipmentUserInterfaceViewTemplate viewTemplate);
    }
}
