using GameEngine.CharacterCreationMaster;
using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.CharacterCreation
{
    public class SelectPreviousAvatarCommand : Command
    {
        public CharacterCreationData CharacterData { get; set; }
        public NewGameViewModel ViewModel { get; set; }
        public SelectPreviousAvatarCommand(CharacterCreationData characterData, NewGameViewModel viewModel)
        {
            CharacterData = characterData;
            ViewModel = viewModel;
        }
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            ViewModel.AvatarSelectionValue--;
            ViewModel.AvatarPath = ViewModel.AvatarsList[ViewModel.AvatarSelectionValue].Path;
            ViewModel.OnPropertyChanged(nameof(ViewModel.AvatarPath));
        }
    }
}
