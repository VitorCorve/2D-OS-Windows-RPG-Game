using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.Armory
{
    public class UpdateEquipmentViewModelCommand : Command
    {
        public EquipmentControlViewModel ViewModel { get; set; }
        public UpdateEquipmentViewModelCommand(EquipmentControlViewModel armoryViewModel) => ViewModel = armoryViewModel;
        public override bool CanExecute(object parameter)
        {
            if (ArmoryTemporaryData.IsEquipmentViewModelChanged)
            {
                ArmoryTemporaryData.IsEquipmentViewModelChanged = false;
                return true;
            }
            else return false;
        }
        public override void Execute(object parameter)
        {
            ViewModel.InventoryModel = null;
            ViewModel.EquipmentModel = null;
            ViewModel.InventoryModel = ArmoryTemporaryData.PlayerInventory;
            ViewModel.EquipmentModel = ArmoryTemporaryData.PlayerEquipment;
            //ViewModel.EquipmentHandler.Refresh();
        }
    }
}
