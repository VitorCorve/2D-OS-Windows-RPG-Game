using GameEngine.CharacterCreationMaster;
using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.CharacterCreation
{
    public class SelectIntellectDescriptionCommand : Command
    {
        public CharacterCreationData CharacterData { get; set; }
        public NewGameViewModel ViewModel { get; set; }
        public SelectIntellectDescriptionCommand(CharacterCreationData characterData, NewGameViewModel viewModel)
        {
            CharacterData = characterData;
            ViewModel = viewModel;
        }
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            CharacterData.AttributeDescription = CharacterData.AttributesDescriptionList[3];
            ViewModel.OnPropertyChanged(nameof(CharacterData));
        }
    }
}
