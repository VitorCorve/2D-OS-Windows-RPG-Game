using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.Armory
{
    public class UpdateMerchantViewModelCommand : Command
    {
        public MerchantControlViewModel ViewModel { get; set; }
        public UpdateMerchantViewModelCommand(MerchantControlViewModel merchantControlViewModel) => ViewModel = merchantControlViewModel;
        public override bool CanExecute(object parameter)
        {
            if (ArmoryTemporaryData.IsMerchantViewModelChanged)
            {
                ArmoryTemporaryData.IsMerchantViewModelChanged = false;
                return true;
            }
            else return false;
        }
        public override void Execute(object parameter)
        {
            ViewModel.PlayerInventory = null;
            ViewModel.PlayerWearedEquipment = null;
            ViewModel.PlayerInventory = ArmoryTemporaryData.PlayerInventory;
            ViewModel.PlayerWearedEquipment = ArmoryTemporaryData.PlayerEquipment;
            ViewModel.RefreshEquipmentView();
        }
    }
}
