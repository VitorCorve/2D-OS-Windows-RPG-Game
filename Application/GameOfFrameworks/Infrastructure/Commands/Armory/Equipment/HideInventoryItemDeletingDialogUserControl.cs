using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;
using System;
using System.Windows.Input;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Equipment
{
    public class HideInventoryItemDeletingDialogUserControl : ICommand
    {
        public EquipmentControlViewModel ViewModel { get; }
        public event EventHandler CanExecuteChanged;
        public HideInventoryItemDeletingDialogUserControl(EquipmentControlViewModel equipmentControlViewModel) => ViewModel = equipmentControlViewModel;
        public bool CanExecute(object parameter) => true;
        public void Execute(object parameter) => ViewModel.InventoryItemDeletingDialogUserControl = System.Windows.Visibility.Hidden;
    }
}
