using GameEngine.CharacterCreationMaster;
using GameEngine.CharacterCreationMaster.Services;
using GameEngine.Player;
using GameEngine.Player.Abstract;
using GameEngine.Player.Specializatons.Mage;
using GameEngine.Player.Specializatons.Rogue;
using GameEngine.Player.Specializatons.Warrior;

namespace GameOfFrameworks.Models.CharacterCreation.Services
{
    public class ConvertPlayerModelToCharacterCreationData
    {
        public CharacterCreationData Convert(PlayerModelData playerModel)
        {
            var characterCreationData = new CharacterCreationData();
            characterCreationData.AvatarPath = playerModel.AvatarPath;
            characterCreationData.AttributeDescription = characterCreationData.AttributesDescriptionList[0];
            characterCreationData.Bio = playerModel.Bio;
            characterCreationData.CharacterSpecialization = playerModel.Specialization;
            characterCreationData.CharacterAttributes = SetCharacterAttributesBySpecialization(characterCreationData.CharacterSpecialization);
            characterCreationData.Gender = playerModel.Gender;
            characterCreationData.Name = playerModel.Name;

            var avatarsData = new GetAvatarsData();

            characterCreationData.PlayerAvatarsList = avatarsData.GetAvatarsList(characterCreationData.CharacterSpecialization, characterCreationData.Gender);

            return characterCreationData;
        }
        private IEntityAttributes SetCharacterAttributesBySpecialization(SPECIALIZATION playerSpecialization)
        {
            switch (playerSpecialization)
            {
                case SPECIALIZATION.Rogue:
                    return new EntityModel_Rogue();
                case SPECIALIZATION.Mage:
                    return new EntityModel_Mage();
                default:
                    return new EntityModel_Warrior();
            }
        }
    }
}
