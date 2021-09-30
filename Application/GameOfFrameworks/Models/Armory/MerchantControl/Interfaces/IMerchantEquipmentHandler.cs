using GameOfFrameworks.Models.Armory.EquipmentControl;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;

namespace GameOfFrameworks.Models.Armory.MerchantControl.Interfaces
{
    public interface IMerchantEquipmentHandler
    {
        MerchantControlViewModel ViewModel { get; }
        void BuyItem(EquipmentUserInterfaceViewTemplate itemTemplate);
        void SellItem(EquipmentUserInterfaceViewTemplate itemTemplate);
        void SetItemRepairCostValue();
        void SetItemRepairCostValue(EquipmentUserInterfaceViewTemplate itemTemplate);
        void SetPlayerMoneyValue();
        void RepairAllItems();
        EquipmentUserInterfaceViewTemplate RepairItem(EquipmentUserInterfaceViewTemplate itemTemplate);
    }
}
