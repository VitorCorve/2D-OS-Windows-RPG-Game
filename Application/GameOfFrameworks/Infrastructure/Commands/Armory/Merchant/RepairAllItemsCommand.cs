using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Merchant
{
    public class RepairAllItemsCommand : Command
    {
        private MerchantControlViewModel ViewModel { get; }
        public RepairAllItemsCommand(MerchantControlViewModel merchantControlViewModel) => ViewModel = merchantControlViewModel;
        public override bool CanExecute(object parameter)
        {
            ViewModel.EquipmentHandler.SetItemRepairCostValue();
            ViewModel.EquipmentHandler.SetPlayerMoneyValue();
            ViewModel.EquipmentHandler.Blacksmith.ValidateMoneyValue();
            if (ViewModel.EquipmentHandler.Blacksmith.PermissionToRepair) return true;
            return false;
        }
        public override void Execute(object parameter)
        {
            ViewModel.EquipmentHandler.RepairAllItems();
            ViewModel.PlayerConsumables = ViewModel.EquipmentHandler.Blacksmith.PlayerConsumables;

            if (ViewModel.PlayerInventorySelect != null && ViewModel.PlayerInventorySelect.Status == GameEngine.Equipment.WEARED_STATUS.Weared)
            {
                ViewModel.PlayerInventorySelect.Durability = 100;
            }
            ViewModel.OnPropertyChanged(nameof(ViewModel.PlayerInventorySelect));
        }
    }
}
