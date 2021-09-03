using GameEngine.CharacterCreationMaster;
using GameEngine.Player;
using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.CharacterCreation
{
    public class SelectMaleGenderCommand : Command
    {
        public CharacterCreationData CharacterData { get; set; }
        public NewGameViewModel ViewModel { get; set; }
        public SelectMaleGenderCommand(CharacterCreationData characterData, NewGameViewModel viewModel)
        {
            CharacterData = characterData;
            ViewModel = viewModel;
        }
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            CharacterData.Gender = GENDER.Male;
            ViewModel.OnPropertyChanged(nameof(CharacterData));
        }
    }
}
