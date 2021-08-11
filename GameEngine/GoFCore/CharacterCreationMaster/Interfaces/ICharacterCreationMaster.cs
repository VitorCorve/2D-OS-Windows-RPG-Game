using GameEngine.CharacterCreationMaster.Services;

namespace GameEngine.CharacterCreationMaster.Interfaces
{
    public interface ICharacterCreationMaster
    {
        CharacterCreationData CharacterData { get; }
        CharacterCreationSkillListBuilder SkillBuilder { get; }
        void SelectSpecialization(int index);
        void SelectGender(int index);
        void SelectNextAvatar();
        void SelectPreviousAvatar();
        void SelectAttributeDescription(int index);
    }
}
