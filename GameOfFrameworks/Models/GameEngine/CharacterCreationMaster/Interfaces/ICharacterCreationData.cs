using GameEngine.CombatEngine.Interfaces;
using GameEngine.Player;
using GameEngine.Player.Abstract;
using GameEngine.Player.ModelConditions;
using System.Collections.Generic;

namespace GameEngine.CharacterCreationMaster.Interfaces
{
    public interface ICharacterCreationData
    {
        IEntityAttributes CharacterAttributes { get; set; }
        string Name { get; set; }
        GENDER Gender { get; set; }
        SPECIALIZATION CharacterSpecialization { get; set; }
        PlayerBiography Bio { get; set; }
        List<PlayerAvatar> PlayerAvatarsList { get; set; }
        PlayerAvatar Avatar { get; set; }
        int AvatarSelectionValue { get; set; }
        int AvatarsCount { get; set; }
        List<string> AttributesDescriptionList { get; set; }
        string AttributeDescription { get; set; }
        List<ISkill> AvailableSkills { get; set; }

    }
}
