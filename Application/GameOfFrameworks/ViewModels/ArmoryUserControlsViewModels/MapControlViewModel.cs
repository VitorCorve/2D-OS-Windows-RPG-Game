using GalaSoft.MvvmLight.Views;
using GameEngine.Locations;
using GameEngine.Locations.Interfaces;
using GameEngine.Locations.Services;
using GameOfFrameworks.Infrastructure.Commands.Armory.Map;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.Models.UIVisualisation;
using GameOfFrameworks.ViewModels.Base;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels
{
    public class MapControlViewModel : ViewModel
    {
        private Visibility _CharacterTravelingControlVisibility;
        private Visibility _TravelingButtonElementVisibility;
        private ILocation _CurrentLocation;
        private ILocation _SelectedLocation;
        public ILocation SelectedLocation { get => _SelectedLocation; set => Set(ref _SelectedLocation, value); }
        public ILocation CurrentLocation { get => _CurrentLocation; set => Set(ref _CurrentLocation, value); }
        public LocationBuilder LocationBuilderService { get; set; } = new();
        public Visibility CharacterTravelingControlVisibility { get => _CharacterTravelingControlVisibility; set => Set(ref _CharacterTravelingControlVisibility, value); }
        public Visibility TravelingButtonElementVisibility { get => _TravelingButtonElementVisibility; set => Set(ref _TravelingButtonElementVisibility, value); }
        public ICommand SelectLocationToTravelCommand { get; private set; }
        public ICommand HideCharacterTravelingControlCommand { get; private set; }
        public ICommand ShowCharacterTravelingControlCommand { get; private set; }
        public ICommand TravelToSelectedLocationCommand { get; private set; }
        public TownMapElementView IronhideTownElement { get; set; } = new(TOWN.Ironhide);
        public TownMapElementView RoughwarkTownElement { get; set; } = new(TOWN.Roughwark);
        public TownMapElementView FrozencoreTownElement { get; set; } = new(TOWN.Frozencore);
        public TownMapElementView AnvilrestTownElement { get; set; } = new(TOWN.Anvilrest);
        public TownMapElementView ElfinelTownElement { get; set; } = new(TOWN.Elfinel);
        public TownMapElementView DarkFortressTownElement { get; set; } = new(TOWN.Dark_Fortress);
        public TownMapElementView ChartringfallTownElement { get; set; } = new(TOWN.Chartringfall);
        public List<TownMapElementView> Towns { get; set; } = new();
        public MapControlViewModel()
        {
            CurrentLocation = ArmoryTemporaryData.CurrentLocation;
            CharacterTravelingControlVisibility = Visibility.Hidden;
            SelectedLocation = LocationBuilderService.Build(CurrentLocation.Town);
            InitializeCommands();
            InitializeTownElements();
            CheckLocation();
        }
        private void InitializeCommands()
        {
            SelectLocationToTravelCommand = new SelectLocationToTravelCommand(this);
            HideCharacterTravelingControlCommand = new HideCharacterTravelingControlCommand(this);
            ShowCharacterTravelingControlCommand = new ShowCharacterTravelingControlCommand(this);
            TravelToSelectedLocationCommand = new TravelToSelectedLocationCommand(this);
        }
        private void InitializeTownElements()
        {
            Towns.Add(IronhideTownElement);
            Towns.Add(RoughwarkTownElement);
            Towns.Add(FrozencoreTownElement);
            Towns.Add(AnvilrestTownElement);
            Towns.Add(ElfinelTownElement);
            Towns.Add(DarkFortressTownElement);
            Towns.Add(ChartringfallTownElement);
        }
        public void CheckLocation()
        {
            if (SelectedLocation.Town == CurrentLocation.Town) TravelingButtonElementVisibility = Visibility.Hidden;
            else TravelingButtonElementVisibility = Visibility.Visible;
        }
    }
}
