using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;
using System.Windows.Input;
using System;
using GameOfFrameworks.Models.Services;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Equipment
{
    public class SelectItemInInventoryCommand : ICommand
    {
        public EquipmentControlViewModel ViewModel { get; }
        public event EventHandler CanExecuteChanged;
        public SelectItemInInventoryCommand(EquipmentControlViewModel equipmentControlViewModel) => ViewModel = equipmentControlViewModel;
        public bool CanExecute(object parameter) => true;
        public void Execute(object parameter)
        {
            int selectionIndex = ViewModel.InventoryMouseOverSelectionIndex;
            if (selectionIndex < 0)
                selectionIndex++;
                            var itemDescriptionBuilder = new ItemDescriptionBuilder();
            ViewModel.SelectedItem = ViewModel.ItemsInInventory[selectionIndex];
            ViewModel.ItemDescription = itemDescriptionBuilder.Build(ViewModel.SelectedItem?.Source);
            ViewModel.DescriptionToolTipVisibility = System.Windows.Visibility.Visible;
        }
    }
}
