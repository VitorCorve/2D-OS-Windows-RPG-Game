using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;
using System;
using System.Windows;
using System.Windows.Input;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Map
{
    public class ShowCharacterTravelingControlCommand : ICommand
    {
        public MapControlViewModel ViewModel { get; }
        public event EventHandler CanExecuteChanged;
        public ShowCharacterTravelingControlCommand(MapControlViewModel mapControlViewModel) => ViewModel = mapControlViewModel;
        public bool CanExecute(object parameter) => true;
        public void Execute(object parameter)
        {
            if (ViewModel.SelectedLocation.Town == ViewModel.CurrentLocation.Town) return;
            ViewModel.CharacterTravelingControlVisibility = Visibility.Visible;
        }
    }
}
