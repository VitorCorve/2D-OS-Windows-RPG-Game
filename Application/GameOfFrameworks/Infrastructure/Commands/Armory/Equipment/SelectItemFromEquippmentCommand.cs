using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;
using System.Windows.Input;
using System;
using GameOfFrameworks.Models.Armory.EquipmentControl;
using GameOfFrameworks.Models.Services;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Equipment
{
    public class SelectItemFromEquippmentCommand : ICommand
    {
        public EquipmentControlViewModel ViewModel { get; }
        public event EventHandler CanExecuteChanged;
        public SelectItemFromEquippmentCommand(EquipmentControlViewModel equipmentControlViewModel) => ViewModel = equipmentControlViewModel;
        public bool CanExecute(object parameter)
        {
            var item = (EquipmentUserInterfaceViewTemplate)parameter;
            if (item is null || item.Source is null)
                return false;
            return true;
        }
        public void Execute(object parameter)
        {
            var itemDescriptionBuilder = new ItemDescriptionBuilder();
            var itemToWear = (EquipmentUserInterfaceViewTemplate)parameter;
            ViewModel.EquipmentHandler.SelectItemFromEquipment(itemToWear.EquipmentType);
            ViewModel.ItemDescription = itemDescriptionBuilder.Build(ViewModel.SelectedItem?.Source);
            ViewModel.DescriptionToolTipVisibility = System.Windows.Visibility.Visible;
        }
    }
}
