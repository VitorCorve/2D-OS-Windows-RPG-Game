using GameEngine.Equipment;
using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.Armory.EquipmentControl;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Merchant
{
    public class CalculateItemRepairCostValueCommand : Command
    {
        private MerchantControlViewModel ViewModel { get; }
        public CalculateItemRepairCostValueCommand(MerchantControlViewModel merchantControlViewModel) => ViewModel = merchantControlViewModel;
        public override bool CanExecute(object parameter)
        {
            if (ViewModel.PlayerInventorySelect is null) return false;
            if (ViewModel.PlayerInventorySelect.Durability == 100) return false;
            return true;
        }
        public override void Execute(object parameter)
        {
            var item = (EquipmentUserInterfaceViewTemplate)parameter;
            ViewModel.RepairCostValue = new CostValue(100 - item.Durability);
        }
    }
}
