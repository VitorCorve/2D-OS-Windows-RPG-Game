using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;
using System.Windows.Input;
using System;
using GameOfFrameworks.Models.Armory.EquipmentControl;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Equipment
{
    public class TakeOffWearedItemCommand : ICommand
    {
        public EquipmentControlViewModel ViewModel { get; }
        public event EventHandler CanExecuteChanged;
        public TakeOffWearedItemCommand(EquipmentControlViewModel equipmentControlViewModel) => ViewModel = equipmentControlViewModel;
        public bool CanExecute(object parameter)
        {
            if (parameter is null)
                return false;
            return true;
        }
        public void Execute(object parameter)
        {
            var itemToTakeOff = (EquipmentUserInterfaceViewTemplate)parameter;
            ViewModel.EquipmentHandler.TakeOffEquippedItem(itemToTakeOff);
            ViewModel.SaveInventoryChanges();
        }
    }
}
