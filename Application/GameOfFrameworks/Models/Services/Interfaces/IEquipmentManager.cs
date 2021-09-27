using GameOfFrameworks.Models.Armory.EquipmentControl;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;


namespace GameOfFrameworks.Models.Services.Interfaces
{
    public interface IEquipmentManager
    {
        EquipmentControlViewModel ViewModel { get; }
        void WearItemFromInventory(EquipmentUserInterfaceViewTemplate viewTemplate);
        void TakeOffEquippedItem(EquipmentUserInterfaceViewTemplate viewTemplate);
    }
}
