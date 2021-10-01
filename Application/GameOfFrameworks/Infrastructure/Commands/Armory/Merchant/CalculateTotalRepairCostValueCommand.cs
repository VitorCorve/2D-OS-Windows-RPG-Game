using GameEngine.Equipment;
using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Merchant
{
    public class CalculateTotalRepairCostValueCommand : Command
    {
        private MerchantControlViewModel ViewModel { get; }
        public CalculateTotalRepairCostValueCommand(MerchantControlViewModel merchantControlViewModel) => ViewModel = merchantControlViewModel;
        public override bool CanExecute(object parameter)
        {
            foreach (var item in ViewModel.PlayerWearedEquipment.ItemsList)
            {
                if (item.ItemDurability.Value < 100) return true;
            }
            foreach (var item in ViewModel.PlayerInventory.ItemsInInventory)
            {
                if (item.ItemDurability.Value < 100) return true;
            }
            return false;
        }
        public override void Execute(object parameter)
        {
            int repairCostValue = 0;
            foreach (var item in ViewModel.PlayerWearedEquipment.ItemsList)
            {
                repairCostValue += 100 - item.ItemDurability.Value;
            }
            foreach (var item in ViewModel.PlayerInventory.ItemsInInventory)
            {
                repairCostValue += 100 - item.ItemDurability.Value;
            }
            ViewModel.RepairCostValue = new CostValue(repairCostValue);
        }
    }
}
