using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;
using System.Windows.Input;
using System;
using GameOfFrameworks.Models.Services;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Equipment
{
    public class SelectSecondWeaponInfoCommand : ICommand
    {
        public EquipmentControlViewModel ViewModel { get; }
        public event EventHandler CanExecuteChanged;
        public SelectSecondWeaponInfoCommand(EquipmentControlViewModel equipmentControlViewModel) => ViewModel = equipmentControlViewModel;
        public bool CanExecute(object parameter)
        {
            if (ViewModel.WearedItemsList.SecondWeapon is null) return false;
            else return true;
        }
        public void Execute(object parameter)
        {
            var itemDescriptionBuilder = new ItemDescriptionBuilder();
            ViewModel.SelectedItem = ViewModel.WearedItemsList.SecondWeapon;
            ViewModel.ItemDescription = itemDescriptionBuilder.Build(ViewModel.SelectedItem?.Source);
            ViewModel.DescriptionToolTipVisibility = System.Windows.Visibility.Visible;
        }
    }
}
