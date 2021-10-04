using GameEngine.Locations;
using GameEngine.Locations.Interfaces;
using GameEngine.Locations.Services;
using GameOfFrameworks.Infrastructure.Commands.Armory.Map;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels.Base;
using System.Windows;
using System.Windows.Input;

namespace GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels
{
    public class MapControlViewModel : ViewModel
    {
        private Visibility _CharacterTravelingControlVisibility;
        private ILocation _CurrentLocation;
        private ILocation _SelectedLocation;
        public ILocation SelectedLocation { get => _SelectedLocation; set => Set(ref _SelectedLocation, value); }
        public ILocation CurrentLocation { get => _CurrentLocation; set => Set(ref _CurrentLocation, value); }
        public LocationBuilder LocationBuilderService { get; set; } = new();
        public Visibility CharacterTravelingControlVisibility { get => _CharacterTravelingControlVisibility; set => Set(ref _CharacterTravelingControlVisibility, value); }
        public ICommand SelectLocationToTravelCommand { get; private set; }
        public ICommand HideCharacterTravelingControlCommand { get; private set; }
        public ICommand ShowCharacterTravelingControlCommand { get; private set; }
        public ICommand TravelToSelectedLocationCommand { get; private set; }
        public MapControlViewModel()
        {
            CurrentLocation = ArmoryTemporaryData.CurrentLocation;
            CharacterTravelingControlVisibility = Visibility.Hidden;
            SelectedLocation = LocationBuilderService.Build(CurrentLocation.Town);
            InitializeCommands();
        }
        private void InitializeCommands()
        {
            SelectLocationToTravelCommand = new SelectLocationToTravelCommand(this);
            HideCharacterTravelingControlCommand = new HideCharacterTravelingControlCommand(this);
            ShowCharacterTravelingControlCommand = new ShowCharacterTravelingControlCommand(this);
            TravelToSelectedLocationCommand = new TravelToSelectedLocationCommand(this);
        }
    }
}
