using GameEngine.MerchantMechanics.Services;
using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.Services;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Merchant
{
    public class ShowItemsInInventoryCommand : Command
    {
        private MerchantControlViewModel ViewModel { get; }
        public ShowItemsInInventoryCommand(MerchantControlViewModel merchantControlViewModel) => ViewModel = merchantControlViewModel;
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            var pricesConverter = new PricesConverter();
            var itemEntityConverter = new ItemEntityConverter();
            pricesConverter.Convert(1.2, ViewModel.PlayerInventory.ItemsInInventory);
            ViewModel.PlayerItems = itemEntityConverter.ConvertRangeToObservableCollection(ViewModel.PlayerWearedEquipment.ItemsList);
        }
    }
}
