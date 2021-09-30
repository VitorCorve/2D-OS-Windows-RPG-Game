using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.Armory.EquipmentControl;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Merchant
{
    public class RepairItemCommand : Command
    {
        private MerchantControlViewModel ViewModel { get; }
        public RepairItemCommand(MerchantControlViewModel merchantControlViewModel) => ViewModel = merchantControlViewModel;
        public override bool CanExecute(object parameter)
        {
            if (ViewModel.PlayerInventorySelect is null) return false;
            if (ViewModel.PlayerInventorySelect?.Durability == 100) return false;
            var item = (EquipmentUserInterfaceViewTemplate)parameter;
            ViewModel.EquipmentHandler.SetItemRepairCostValue(item);
            ViewModel.EquipmentHandler.SetPlayerMoneyValue();
            ViewModel.EquipmentHandler.Blacksmith.ValidateMoneyValue();
            if (ViewModel.EquipmentHandler.Blacksmith.PermissionToRepair) return true;
            return false;
        }
        public override void Execute(object parameter)
        {
            var item = (EquipmentUserInterfaceViewTemplate)parameter;
            ViewModel.EquipmentHandler.RepairItem(item);
            ViewModel.PlayerConsumables = ViewModel.EquipmentHandler.Blacksmith.PlayerConsumables;

            if (ViewModel.PlayerInventorySelect != null)
            {
                ViewModel.PlayerInventorySelect.Durability = 100;
            }
            ViewModel.OnPropertyChanged(nameof(ViewModel.PlayerInventorySelect));
        }
    }
}
