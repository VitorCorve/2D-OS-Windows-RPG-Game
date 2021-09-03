using GameEngine.CharacterCreationMaster;
using GameEngine.Player;
using GameEngine.Player.Specializatons.Rogue;
using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.CharacterCreation
{
    public class SelectRogueClassCommand : Command
    {
        public CharacterCreationData CharacterData { get; set; }
        public NewGameViewModel ViewModel { get; set; }
        public SelectRogueClassCommand(CharacterCreationData characterData, NewGameViewModel viewModel)
        {
            CharacterData = characterData;
            ViewModel = viewModel;
        }
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            CharacterData.CharacterAttributes = new EntityModel_Rogue();
            CharacterData.CharacterSpecialization = SPECIALIZATION.Rogue;
            ViewModel.OnPropertyChanged(nameof(CharacterData));
        }
    }
}
