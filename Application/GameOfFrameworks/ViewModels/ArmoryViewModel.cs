using GameEngine.CombatEngine;
using GameEngine.Player;
using GameOfFrameworks.Infrastructure.Commands.Armory;
using GameOfFrameworks.Models.Services;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels.Base;
using System.Windows.Input;

namespace GameOfFrameworks.ViewModels
{
    public class ArmoryViewModel : ViewModel
    {
        private int _ProgressBarValue;
        public int ProgressBarValue { get => _ProgressBarValue; set => Set(ref _ProgressBarValue, value); }
        private PlayerEntity _CharacterEntity;
        public PlayerEntity CharacterEntity { get => _CharacterEntity; set => Set(ref _CharacterEntity, value); }
        private PlayerModelData _PlayerModel;
        public PlayerModelData PlayeModel { get => _PlayerModel; set => Set(ref _PlayerModel, value); }
        public PlayerExperienceConverter Converter { get; set; }
        public ICommand UpdateArmoryViewModelCommand { get; private set; }
        public ArmoryViewModel()
        {
            if (ArmoryTemporaryData.PlayerModel != null) PlayeModel = ArmoryTemporaryData.PlayerModel;

            if (ArmoryTemporaryData.CharacterEntity != null) CharacterEntity = ArmoryTemporaryData.CharacterEntity;

            Converter = new PlayerExperienceConverter(PlayeModel);

            ProgressBarValue = Converter.Convert();

            UpdateArmoryViewModelCommand = new UpdateArmoryViewModelCommand(this);
        }
    }
}
