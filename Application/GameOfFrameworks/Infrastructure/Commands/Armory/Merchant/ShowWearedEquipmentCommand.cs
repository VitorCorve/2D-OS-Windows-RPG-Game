using GameEngine.MerchantMechanics.Services;
using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.Services;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Merchant
{
    public class ShowWearedEquipmentCommand : Command
    {
        private MerchantControlViewModel ViewModel { get; }
        public ShowWearedEquipmentCommand(MerchantControlViewModel merchantControlViewModel) => ViewModel = merchantControlViewModel;
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            var pricesConverter = new PricesConverter();
            var itemEntityConverter = new ItemEntityConverter();
            pricesConverter.Convert(1.2, ViewModel.PlayerWearedEquipment.ItemsList);
            ViewModel.PlayerItems = itemEntityConverter.ConvertRangeToObservableCollection(ViewModel.PlayerInventory.ItemsInInventory);
        }
    }
}
