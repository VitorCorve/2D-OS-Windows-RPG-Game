using GameOfFrameworks.Models.UISkillsCollection.Player;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;
using System;
using System.Windows.Input;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Equipment
{
    public class DeleteInventoryItemCommand : ICommand
    {
        public EquipmentControlViewModel ViewModel { get; }
        public event EventHandler CanExecuteChanged;
        public DeleteInventoryItemCommand(EquipmentControlViewModel equipmentControlViewModel) => ViewModel = equipmentControlViewModel;
        public bool CanExecute(object parameter) => true;
        public void Execute(object parameter)
        {
            var itemToDelete = (EquipmentUserInterfaceViewTemplate)parameter;
            ViewModel.EquipmentHandler.DeleteInventoryItem(itemToDelete);
            ViewModel.InventoryItemDeletingDialogUserControl = System.Windows.Visibility.Hidden;
            ViewModel.SaveInventoryChanges();
        }
    }
}
