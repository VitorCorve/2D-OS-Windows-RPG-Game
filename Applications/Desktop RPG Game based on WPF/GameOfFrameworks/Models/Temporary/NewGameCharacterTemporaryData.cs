using GameEngine.CombatEngine;
using GameEngine.Player;
using GameEngine.Player.Abstract;
using GameOfFrameworks.Models.CharacterCreation;

namespace GameOfFrameworks.Models.Temporary
{
    public static class NewGameCharacterTemporaryData
    {
        public static PlayerModelData PlayerModel { get; set; }
        public static PlayerEntity PlayerEntity { get; set; }
        public static IEntityAttributes CharacterBaseAttributes { get; set; }
        public static CharacterSpecializationDescription SpecializationDescription { get; set; }
    }
}
