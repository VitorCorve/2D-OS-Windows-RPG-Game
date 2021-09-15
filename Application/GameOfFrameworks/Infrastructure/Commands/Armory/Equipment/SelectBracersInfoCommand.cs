using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;
using System.Windows.Input;
using System;
using GameOfFrameworks.Models.Services;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Equipment
{
    public class SelectBracersInfoCommand : ICommand
    {
        public EquipmentControlViewModel ViewModel { get; }
        public event EventHandler CanExecuteChanged;
        public SelectBracersInfoCommand(EquipmentControlViewModel equipmentControlViewModel) => ViewModel = equipmentControlViewModel;
        public bool CanExecute(object parameter)
        {
            if (ViewModel.WearedItemsList.Bracers is null) return false;
            else return true;
        }
        public void Execute(object parameter)
        {
            var itemDescriptionBuilder = new ItemDescriptionBuilder();
            ViewModel.SelectedItem = ViewModel.WearedItemsList.Bracers;
            ViewModel.ItemDescription = itemDescriptionBuilder.Build(ViewModel.SelectedItem?.Source);
            ViewModel.DescriptionToolTipVisibility = System.Windows.Visibility.Visible;
        }
    }
}
