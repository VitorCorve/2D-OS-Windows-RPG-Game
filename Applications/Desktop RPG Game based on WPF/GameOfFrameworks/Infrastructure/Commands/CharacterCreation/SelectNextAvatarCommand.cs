using GameEngine.CharacterCreationMaster;
using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.CharacterCreation
{
    public class SelectNextAvatarCommand : Command
    {
        public NewGameViewModel ViewModel { get; set; }
        public CharacterCreationData CreationData { get; set; }
        public SelectNextAvatarCommand(CharacterCreationData creationData, NewGameViewModel viewModel)
        {
            ViewModel = viewModel;
            CreationData = creationData;
        }
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            ViewModel.AvatarSelectionValue++;
            ViewModel.AvatarPath = ViewModel.AvatarsList[ViewModel.AvatarSelectionValue].Path;
            ViewModel.OnPropertyChanged(nameof(ViewModel.AvatarPath));
        }
    }
}
