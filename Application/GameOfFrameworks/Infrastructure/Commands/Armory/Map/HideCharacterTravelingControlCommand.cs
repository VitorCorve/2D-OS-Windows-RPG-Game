using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;
using System;
using System.Windows;
using System.Windows.Input;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Map
{
    public class HideCharacterTravelingControlCommand : ICommand
    {
        public MapControlViewModel ViewModel { get; }
        public event EventHandler CanExecuteChanged;
        public HideCharacterTravelingControlCommand(MapControlViewModel mapControlViewModel) => ViewModel = mapControlViewModel;
        public bool CanExecute(object parameter) => true;
        public void Execute(object parameter) => ViewModel.CharacterTravelingControlVisibility = Visibility.Hidden;
    }
}
