using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;
using System.Windows.Input;
using System;


namespace GameOfFrameworks.Infrastructure.Commands.Armory.Equipment
{
    public class SelectHelmetInfoCommand : ICommand
    {
        public EquipmentControlViewModel ViewModel { get; }
        public event EventHandler CanExecuteChanged;
        public SelectHelmetInfoCommand(EquipmentControlViewModel equipmentControlViewModel) => ViewModel = equipmentControlViewModel;
        public bool CanExecute(object parameter) => true;
        public void Execute(object parameter) => ViewModel.SelectedItem = ViewModel.WearedItemsList.Helmet;
    }
}
