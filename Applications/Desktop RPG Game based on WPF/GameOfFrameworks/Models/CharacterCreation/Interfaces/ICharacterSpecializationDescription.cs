using GameEngine.Player;

namespace GameOfFrameworks.Models.CharacterCreation.Interfaces
{
    public interface ICharacterSpecializationDescription
    {
        string Description { get; }
        void SetDescription(SPECIALIZATION playerSpecialization);
    }
}
