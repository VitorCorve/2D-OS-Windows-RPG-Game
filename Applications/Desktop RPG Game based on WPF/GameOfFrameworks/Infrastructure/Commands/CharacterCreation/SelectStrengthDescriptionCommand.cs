using GameEngine.CharacterCreationMaster;
using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.CharacterCreation
{
    public class SelectStrengthDescriptionCommand : Command
    {
        public CharacterCreationData CharacterData { get; set; }
        public NewGameViewModel ViewModel { get; set; }
        public SelectStrengthDescriptionCommand(CharacterCreationData characterData, NewGameViewModel viewModel)
        {
            CharacterData = characterData;
            ViewModel = viewModel;
        }
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            CharacterData.AttributeDescription = CharacterData.AttributesDescriptionList[0];
            ViewModel.OnPropertyChanged(nameof(CharacterData));
        }
    }
}
