using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.Armory.EquipmentControl;
using GameOfFrameworks.ViewModels;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;
using System;

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
            try
            {
                var item = (EquipmentUserInterfaceViewTemplate)parameter;
                ViewModel.EquipmentHandler.BuyItem(item);
                ViewModel.PlayerItemsInInventoryCount = ViewModel.PlayerInventory.ItemsInInventory.Count;
                ViewModel.MerchantInventorySelect = null;
            }
            catch (Exception e)
            {

                MainWindowViewModel.ShowNotificationCommand.Execute(e.Message);
            }

        }
    }
}
