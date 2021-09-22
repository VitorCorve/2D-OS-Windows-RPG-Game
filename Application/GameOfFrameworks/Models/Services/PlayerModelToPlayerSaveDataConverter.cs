using GameEngine.Data;
using GameEngine.Player;

namespace GameOfFrameworks.Models.Services
{
    public class PlayerModelToPlayerSaveDataConverter
    {
        public PlayerSaveData Convert(PlayerModelData playerModelData, PlayerSkillList playerSkillList = null)
        {
            var playerSaveData = new PlayerSaveData();
            playerSaveData.Name = playerModelData.Name;
            playerSaveData.Specialization = playerModelData.Specialization;

            if (playerSkillList != null) playerSaveData.PlayerSkills = playerSkillList;
 
            playerSaveData.Level = playerModelData.Level;
            playerSaveData.AvailableSkillPoints = playerModelData.PlayerConsumables.SkillPointsValue.Value;
            playerSaveData.Gender = playerModelData.Gender;
            playerSaveData.Money = playerModelData.PlayerConsumables.AbsoluteMoneyValue;
            playerSaveData.Bio = playerModelData.Bio;
            playerSaveData.AvatarPath = playerModelData.AvatarPath;

            return playerSaveData;
        }
    }
}
