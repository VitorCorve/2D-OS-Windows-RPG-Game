using GameEngine.CharacterCreationMaster.AvatarsNavigation;
using GameEngine.CharacterCreationMaster.Interfaces;
using GameEngine.CharacterCreationMaster.Interfaces.Services;
using GameEngine.Player;
using GameEngine.Player.ModelConditions;
using GameEngine.Player.Specializatons.Mage;
using System.Collections.Generic;

namespace GameEngine.CharacterCreationMaster.Services
{
    public class GetAvatarsData : IGetAvatarsData
    {
        public IAvatarPaths Collection { get; private set; }
        public List<PlayerAvatar> GetAvatarsList(SPECIALIZATION playerSpecialization)
        {
            var avatarsList = new List<PlayerAvatar>();

            switch (playerSpecialization)
            {
                case SPECIALIZATION.Mage:
                    Collection = new MageAvatarPaths();
                    break;
                case SPECIALIZATION.Rogue:
                    Collection = new RogueAvatarPaths();
                    break;
                default:
                    Collection = new WarriorAvatarsPaths();
                    break;
            }

            foreach (var item in Collection.AvatarsData)
            {
                var avatarData = new PlayerAvatar();
                avatarData.ID = item.Key;
                avatarData.Path = item.Value;
                avatarsList.Add(avatarData);
            }

            return avatarsList;
        }
    }
}
