using GameEngine.Locations;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;
using System;
using System.Windows.Input;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Map
{
    public class SelectLocationToTravelCommand : ICommand
    {
        public MapControlViewModel ViewModel { get; }
        public event EventHandler CanExecuteChanged;
        public SelectLocationToTravelCommand(MapControlViewModel mapControlViewModel) => ViewModel = mapControlViewModel;
        public bool CanExecute(object parameter) => true;
        public void Execute(object parameter)
        {
            var town = (TOWN)Enum.Parse(typeof(TOWN), (string)parameter);
            ViewModel.SelectedLocation = ViewModel.LocationBuilderService.Build(town);
            foreach (var item in ViewModel.Towns)
            {
                if (item.Name == town) item.IsSelected = true;
                else item.IsSelected = false;
            }
            ViewModel.CheckLocation();
        }
    }
}
