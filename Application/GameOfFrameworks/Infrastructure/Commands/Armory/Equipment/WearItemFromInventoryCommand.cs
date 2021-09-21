using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;
using System.Windows.Input;
using System;
using GameOfFrameworks.Models.UISkillsCollection.Player;
using GameOfFrameworks.Models.Services;

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
            var itemEntityConverter = new ItemEntityConverter();
            var itemToWear = (EquipmentUserInterfaceViewTemplate)parameter;
            ViewModel.EquipmentHandler.WearItemFromInventory(itemToWear);
            ViewModel.SaveInventoryChanges();
        }
    }
}
