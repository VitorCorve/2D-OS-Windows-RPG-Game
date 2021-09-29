using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Merchant
{
    public class ShowWearedEquipmentCommand : Command
    {
        private MerchantControlViewModel ViewModel { get; }
        public ShowWearedEquipmentCommand(MerchantControlViewModel merchantControlViewModel) => ViewModel = merchantControlViewModel;
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter) => ViewModel.ShowWearedEquipment();
    }
}
