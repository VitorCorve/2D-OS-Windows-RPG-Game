using GameEngine.CharacterCreationMaster;
using GameEngine.CharacterCreationMaster.Services;
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

            ViewModel.SpecializationDescription.SetDescription(CharacterData.CharacterSpecialization);

            var avatarsData = new GetAvatarsData();
            ViewModel.AvatarsList = avatarsData.GetAvatarsList(CharacterData.CharacterSpecialization, CharacterData.Gender);
            ViewModel.CharacterData.AvatarPath.Path = ViewModel.AvatarsList[0].Path;

            ViewModel.OnPropertyChanged(nameof(ViewModel.CharacterData.AvatarPath.Path));
            ViewModel.OnPropertyChanged(nameof(CharacterData));
            ViewModel.OnPropertyChanged(nameof(ViewModel.SpecializationDescription));
        }
    }
}
