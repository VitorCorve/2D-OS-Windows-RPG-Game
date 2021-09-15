using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;
using System.Windows.Input;
using System;
using GameOfFrameworks.Models.Services;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Equipment
{
    public class SelectBootsInfoCommand : ICommand
    {
        public EquipmentControlViewModel ViewModel { get; }
        public event EventHandler CanExecuteChanged;
        public SelectBootsInfoCommand(EquipmentControlViewModel equipmentControlViewModel) => ViewModel = equipmentControlViewModel;
        public bool CanExecute(object parameter)
        {
            if (ViewModel.WearedItemsList.Boots is null) return false;
            else return true;
        }
        public void Execute(object parameter)
        {
            var itemDescriptionBuilder = new ItemDescriptionBuilder();
            ViewModel.SelectedItem = ViewModel.WearedItemsList.Boots;
            ViewModel.ItemDescription = itemDescriptionBuilder.Build(ViewModel.SelectedItem?.Source);
            ViewModel.DescriptionToolTipVisibility = System.Windows.Visibility.Visible;
        }
    }
}
