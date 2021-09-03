using GameEngine.CharacterCreationMaster;
using GameEngine.Player;
using GameEngine.Player.Specializatons.Warrior;
using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.CharacterCreation
{
    public class SelectWarriorClassCommand : Command
    {
        public CharacterCreationData CharacterData { get; set; }
        public NewGameViewModel ViewModel { get; set; }
        public SelectWarriorClassCommand(CharacterCreationData characterData, NewGameViewModel viewModel)
        {
            CharacterData = characterData;
            ViewModel = viewModel;
        }
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            CharacterData.CharacterAttributes = new EntityModel_Warrior();
            CharacterData.CharacterSpecialization = SPECIALIZATION.Warrior;
            ViewModel.OnPropertyChanged(nameof(CharacterData));
        }
    }
}
