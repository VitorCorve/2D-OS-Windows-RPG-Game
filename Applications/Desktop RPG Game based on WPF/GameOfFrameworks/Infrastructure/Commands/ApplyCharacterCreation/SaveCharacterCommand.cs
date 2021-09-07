using GameEngine.Data;
using GameEngine.Data.Services;
using GameEngine.Player;
using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.Services;

namespace GameOfFrameworks.Infrastructure.Commands.ApplyCharacterCreation
{
    public class SaveCharacterCommand : Command
    {
        public PlayerModelData PlayerModel { get; set; }
        public PlayerSaveData DataToSave { get; private set; }
        public SaveGameService SaveService { get; private set; }
        public PlayerSkillList SkillList { get; private set; } 
        public GetAvailablePlayerSkills AvailableSkillListManager { get; set; }
        public PlayerModelToPlayerSaveDataConverter DataConverter { get; set; }
        public SaveCharacterCommand(PlayerModelData playerModelData) => PlayerModel = playerModelData;

        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            InitializeManagers();
            SetAvailableSkillList();
            ConvertData();
            SaveData();
        }
        private void InitializeManagers()
        {
            DataToSave = new PlayerSaveData();
            SaveService = new SaveGameService();
            SkillList = new PlayerSkillList();
            AvailableSkillListManager = new GetAvailablePlayerSkills(PlayerModel);
            DataConverter = new PlayerModelToPlayerSaveDataConverter();
        }
        private void SetAvailableSkillList() => SkillList.Skills = AvailableSkillListManager.SkillList;
        private void ConvertData() => DataToSave = DataConverter.Convert(PlayerModel, SkillList);
        private void SaveData() => SaveService.Save(DataToSave);
    }
}
