using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;
using System.Windows.Input;
using System;
using GameOfFrameworks.Models.Services;
using System.Windows;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Equipment
{
    public class SelectShouldersInfoCommand : ICommand
    {
        public EquipmentControlViewModel ViewModel { get; }
        public event EventHandler CanExecuteChanged;
        public SelectShouldersInfoCommand(EquipmentControlViewModel equipmentControlViewModel) => ViewModel = equipmentControlViewModel;
        public bool CanExecute(object parameter)
        {
            if (ViewModel.WearedItemsList.Shoulders is null) return false;
            else return true;
        }
        public void Execute(object parameter)
        {
            var itemDescriptionBuilder = new ItemDescriptionBuilder();
            ViewModel.SelectedItem = ViewModel.WearedItemsList.Shoulders;
            ViewModel.ItemDescription = itemDescriptionBuilder.Build(ViewModel.SelectedItem?.Source);
            ViewModel.DescriptionToolTipVisibility = System.Windows.Visibility.Visible;
        }
    }
}
