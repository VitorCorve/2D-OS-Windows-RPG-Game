using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Merchant
{
    public class ShowItemsInInventoryCommand : Command
    {
        private MerchantControlViewModel ViewModel { get; }
        public ShowItemsInInventoryCommand(MerchantControlViewModel merchantControlViewModel) => ViewModel = merchantControlViewModel;
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter) => ViewModel.ShowInventory();
    }
}
