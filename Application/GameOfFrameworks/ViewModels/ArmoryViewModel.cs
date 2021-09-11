using GameEngine.CombatEngine;
using GameEngine.Player;
using GameOfFrameworks.Models.Services;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels.Base;
using System;

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
        public ArmoryViewModel()
        {
            if (ArmoryTemporaryData.PlayerModel != null) PlayeModel = ArmoryTemporaryData.PlayerModel;
            else throw new Exception(EmptyDataExp());
            if (ArmoryTemporaryData.CharacterEntity != null) CharacterEntity = ArmoryTemporaryData.CharacterEntity;
            else throw new Exception(EmptyDataExp());
            Converter = new PlayerExperienceConverter(PlayeModel);
            ProgressBarValue = Converter.Convert();
        }
        private string EmptyDataExp() => "Temporary data is empty";
    }
}
