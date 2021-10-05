using GameEngine.Data;
using GameEngine.Data.Interfaces;
using GameEngine.Data.Services;
using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.Temporary;
using System;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Options
{
    public class SaveGameCommand : Command
    {
        private PlayerSaveData DataToSave;
        private SaveGameService SaveService;
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            InitializeManagers();
            PrepareSaveData();
            SetDataSaveTime();
            SaveData();
        }
        private void InitializeManagers()
        {
            DataToSave = new PlayerSaveData();
            SaveService = new SaveGameService();
        }
        private void PrepareSaveData()
        {
            var playerSaveDataBuilder = new PlayerSaveDataBuilder();
            DataToSave = playerSaveDataBuilder.Build(
                ArmoryTemporaryData.PlayerModel,
                ArmoryTemporaryData.CurrentLocation,
                ArmoryTemporaryData.PlayerInventory,
                ArmoryTemporaryData.PlayerEquipment,
                ArmoryTemporaryData.PlayerSkills);
        }
        private void SetDataSaveTime() => DataToSave.Date = DateTime.Now.ToString("yy.MM.dd H:mm:ss");
        private void SaveData() => SaveService.Save(DataToSave);
    }
}
