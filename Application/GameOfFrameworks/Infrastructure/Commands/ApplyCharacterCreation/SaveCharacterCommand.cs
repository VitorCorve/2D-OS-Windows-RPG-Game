using GameEngine.Data;
using GameEngine.Data.Services;
using GameEngine.Player;
using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.Services;
using GameOfFrameworks.ViewModels;
using System;

namespace GameOfFrameworks.Infrastructure.Commands.ApplyCharacterCreation
{
    public class SaveCharacterCommand : Command
    {
        public ApplyCharacterCreationViewModel ViewModel { get; set; }
        public PlayerModelData PlayerModel { get; set; }
        public PlayerSaveData DataToSave { get; private set; }
        public SaveGameService SaveService { get; private set; }
        public PlayerSkillList SkillList { get; private set; } 
        public AvailableSkillListBuilder AvailableSkillListManager { get; set; }
        public PlayerModelToPlayerSaveDataConverter DataConverter { get; set; }
        public SaveCharacterCommand(PlayerModelData playerModelData, ApplyCharacterCreationViewModel viewModel)
        {
            PlayerModel = playerModelData;
            ViewModel = viewModel;
        }

        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            InitializeManagers();
            SetAvailableSkillList();
            ConvertData();
            SetupCharacterAttributes();
            SetDataSaveTime();
            SaveData();
        }
        private void InitializeManagers()
        {
            DataToSave = new PlayerSaveData();
            SaveService = new SaveGameService();
            SkillList = new PlayerSkillList();
            AvailableSkillListManager = new AvailableSkillListBuilder(PlayerModel);
            DataConverter = new PlayerModelToPlayerSaveDataConverter();
        }
        private void SetAvailableSkillList() => SkillList.Skills = AvailableSkillListManager.SkillList;
        private void SetupCharacterAttributes() => DataToSave.PlayerAttributes = ViewModel.CharacterBasicAttributes;
        private void ConvertData() => DataToSave = DataConverter.Convert(PlayerModel, SkillList);
        private void SaveData() => SaveService.Save(DataToSave);
        private void SetDataSaveTime() => DataToSave.Date = DateTime.Now.ToString("yy.MM.dd H:mm:ss");
    }
}
