using GameEngine.Data.Interfaces.Services;

namespace GameEngine.Data.Services
{
    public class ConvertLoadToSaveFormatService : IConvertLoadToSaveFormatService
    {
        public PlayerSaveData Covert(PlayerLoadData playerData)
        {
            var saveDataFormat = new PlayerSaveData();

            saveDataFormat.ItemsOnCharacter.PrepareToSerialize(playerData.Equipment.ItemsList);
            saveDataFormat.ItemsInInventory.PrepareToSerialize(playerData.Inventory.ItemsInInventory);
            saveDataFormat.Skills = playerData.ListOfSkills;
            saveDataFormat.AvailableSkillPoints = playerData.PlayerModel.PlayerConsumables.SkillPointsValue.Value;
            saveDataFormat.Level = playerData.PlayerModel.Level;
            saveDataFormat.Name = playerData.PlayerModel.Name;
            saveDataFormat.Specialization = playerData.PlayerModel.Specialization;
            saveDataFormat.Gender = playerData.PlayerModel.Gender;
            saveDataFormat.Money = playerData.PlayerModel.PlayerConsumables.AbsoluteMoneyValue;
            saveDataFormat.Bio = playerData.PlayerModel.Bio;
            saveDataFormat.Avatar_ID = playerData.PlayerModel.Avatar_ID;

            return saveDataFormat;
        }
    }
}
