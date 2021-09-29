using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;
using System.Windows.Input;
using System;
using GameOfFrameworks.Models.Services;
using GameOfFrameworks.Models.Armory.EquipmentControl;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Equipment
{
    public class WearItemFromInventoryCommand : ICommand
    {
        public EquipmentControlViewModel ViewModel { get; }
        public event EventHandler CanExecuteChanged;
        public WearItemFromInventoryCommand(EquipmentControlViewModel equipmentControlViewModel) => ViewModel = equipmentControlViewModel;
        public bool CanExecute(object parameter)
        {
            if (parameter is null)
                return false;
            return true;
        }
        public void Execute(object parameter)
        {
            var itemToWear = (EquipmentUserInterfaceViewTemplate)parameter;
            ViewModel.EquipmentHandler.WearItemFromInventory(itemToWear);
            ViewModel.SaveInventoryChanges();
        }
    }
}
