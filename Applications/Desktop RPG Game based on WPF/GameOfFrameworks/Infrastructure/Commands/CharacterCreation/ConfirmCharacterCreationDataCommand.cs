using GameEngine.CharacterCreationMaster;
using GameEngine.CombatEngine;
using GameEngine.Player;
using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.CharacterCreation.Services;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.CharacterCreation
{
    public class ConfirmCharacterCreationDataCommand : Command
    {
        public NewGameViewModel ViewModel { get; private set; }
        public CharacterCreationData CharacterData { get; set; }
        public ConfirmCharacterCreationDataCommand(CharacterCreationData characterData, NewGameViewModel newGameViewModel)
        {
            ViewModel = newGameViewModel;
            CharacterData = characterData;
        }
        public override bool CanExecute(object parameter)
        {
            if (CharacterData.Name != null && CharacterData.Name.Length < 1) return false;
            return true;
        }
        public override void Execute(object parameter)
        {
            CharacterData.Name = ConvertCharacterNickname.Convert(CharacterData.Name);
            var playerModelData = new PlayerModelData(CharacterData);
            NewGameCharacterTemporaryData.PlayerModel = playerModelData;
            NewGameCharacterTemporaryData.SpecializationDescription = ViewModel.SpecializationDescription;
            NewGameCharacterTemporaryData.CharacterBaseAttributes = CharacterData.CharacterAttributes;
            NewGameCharacterTemporaryData.AvatarSelectionValue = ViewModel.AvatarSelectionValue;

            var playerEntityConstructor = new PlayerEntityConstructor();
            NewGameCharacterTemporaryData.PlayerEntity = playerEntityConstructor.CreatePlayer(playerModelData, CharacterData.CharacterAttributes);
        }
    }
}
