using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;
using System;
using System.Windows.Input;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Equipment
{
    class ShowInventoryItemPopubDialogUserControlCommand : ICommand
    {
        public EquipmentControlViewModel ViewModel { get; }
        public event EventHandler CanExecuteChanged;
        public ShowInventoryItemPopubDialogUserControlCommand(EquipmentControlViewModel equipmentControlViewModel) => ViewModel = equipmentControlViewModel;
        public bool CanExecute(object parameter)
        {
            if (parameter is null)
                return false;
            return true;
        }
        public void Execute(object parameter) => ViewModel.IsOpenInventoryItemPopupDialogUserControl = true;
    }
}
