using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.Armory.EquipmentControl;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Merchant
{
    public class BuyItemCommand : Command
    {
        private MerchantControlViewModel ViewModel { get; }
        public BuyItemCommand(MerchantControlViewModel merchantControlViewModel) => ViewModel = merchantControlViewModel;
        public override bool CanExecute(object parameter)
        {
            if (ViewModel.PlayerInventory.ItemsInInventory.Count < 48) return true;
            return false;
        }
        public override void Execute(object parameter)
        {
            var item = (EquipmentUserInterfaceViewTemplate)parameter;
            ViewModel.EquipmentHandler.BuyItem(item);
            ViewModel.PlayerItemsInInventoryCount = ViewModel.PlayerInventory.ItemsInInventory.Count;
            ViewModel.MerchantInventorySelect = null;
        }
    }
}
