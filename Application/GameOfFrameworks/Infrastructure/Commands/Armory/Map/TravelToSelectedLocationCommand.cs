using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;
using System;
using System.Windows;
using System.Windows.Input;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Map
{
    public class TravelToSelectedLocationCommand : ICommand
    {
        public MapControlViewModel ViewModel { get; }
        public event EventHandler CanExecuteChanged;
        public TravelToSelectedLocationCommand(MapControlViewModel mapControlViewModel) => ViewModel = mapControlViewModel;
        public bool CanExecute(object parameter) => true;
        public void Execute(object parameter)
        {
            ArmoryTemporaryData.CurrentLocation = ViewModel.SelectedLocation;
            ViewModel.CharacterTravelingControlVisibility = Visibility.Hidden;
            ArmoryViewModel.SaveGameCommand.Execute(null);
            ArmoryTemporaryData.Instance.NavigationService.Navigate(new GameOfFrameworks.Scenes.Armory());
            MainWindowViewModel.ShowNotificationCommand.Execute("Autosave...");
            ArmoryViewModel.LoadAutoSaveDataCommand.Execute(null);
        }
    }
}
