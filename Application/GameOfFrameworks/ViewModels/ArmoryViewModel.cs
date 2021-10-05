using GameEngine.CombatEngine;
using GameEngine.Locations.Interfaces;
using GameEngine.Locations.Services;
using GameEngine.Player;
using GameOfFrameworks.Infrastructure.Commands.ApplyCharacterCreation;
using GameOfFrameworks.Infrastructure.Commands.Armory;
using GameOfFrameworks.Infrastructure.Commands.Armory.Options;
using GameOfFrameworks.Models.Services;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels.Base;
using System.Windows.Input;

namespace GameOfFrameworks.ViewModels
{
    public class ArmoryViewModel : ViewModel
    {
        private ILocation _CurrentLocation;
        private int _ProgressBarValue;
        public int ProgressBarValue { get => _ProgressBarValue; set => Set(ref _ProgressBarValue, value); }
        private PlayerEntity _CharacterEntity;
        public PlayerEntity CharacterEntity { get => _CharacterEntity; set => Set(ref _CharacterEntity, value); }
        private PlayerModelData _PlayerModel;
        public PlayerModelData PlayerModel { get => _PlayerModel; set => Set(ref _PlayerModel, value); }
        public PlayerExperienceConverter Converter { get; set; }
        public ILocation CurrentLocation { get => _CurrentLocation; set => Set(ref _CurrentLocation, value); }
        public ICommand UpdateArmoryViewModelCommand { get; private set; }
        public ICommand SaveGameCommand { get; private set; }
        public ArmoryViewModel()
        {
            var locationBuilder = new LocationBuilder();
            PlayerModel = ArmoryTemporaryData.PlayerModel;

            CharacterEntity = ArmoryTemporaryData.CharacterEntity;

            CurrentLocation = locationBuilder.Build(ArmoryTemporaryData.CurrentLocation.Town);

            Converter = new PlayerExperienceConverter(PlayerModel);

            ProgressBarValue = Converter.Convert();

            UpdateArmoryViewModelCommand = new UpdateArmoryViewModelCommand(this);
            SaveGameCommand = new SaveGameCommand();
        }
    }
}
