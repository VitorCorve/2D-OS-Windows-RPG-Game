using GameEngine.Locations;
using GameOfFrameworks.ViewModels.Base;

namespace GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels
{
    public class MapControlViewModel : ViewModel
    {
        private Location _CurrentLocation;
        public Location CurrentLocation { get => _CurrentLocation; set => Set(ref _CurrentLocation, value); }
        public MapControlViewModel()
        {
            CurrentLocation = new Location(TOWN.Roughwark);
        }
    }
}
