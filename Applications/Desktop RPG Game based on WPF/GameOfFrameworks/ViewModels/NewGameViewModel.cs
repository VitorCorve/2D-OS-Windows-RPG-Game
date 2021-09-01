using GameOfFrameworks.Infrastructure.Commands;
using GameOfFrameworks.Infrastructure.Commands.CharacterCreation;
using GameOfFrameworks.Models.CharacterCreation;
using GameOfFrameworks.ViewModels.Base;
using System.Windows.Input;

namespace GameOfFrameworks.ViewModels
{
    public class NewGameViewModel : ViewModel
    {
        public ICommand ConfirmCharacterCreationDataCommand { get; }
        public ICommand SelectFemaleGenderCommand { get; }
        public ICommand SelectMaleGenderCommand { get; }
        public ICommand SelectNextAvatarCommand { get; }
        public ICommand SelectPreviousAvatarCommand { get; }
        public ICommand SelectRogueClassCommand { get; }
        public ICommand SelectWarriorClassCommand { get; }
        public ICommand SelectMageClassCommand { get; }
        public ICommand UpdateDataCommand { get; }
        public ICommand SelectAttributeDescriptionCommand { get; }
        public string SelectedAttributeDescription { get; }

        private CharacterModel _CharacterModel;
        public CharacterModel Character { get => _CharacterModel; set => Set(ref _CharacterModel, value); }
        public NewGameViewModel()
        {
            Character = new CharacterModel();
            Character.Gender = CharacterCreationManager.CreationMaster.CharacterData.Gender;
            Character.Specialization = CharacterCreationManager.CreationMaster.CharacterData.CharacterSpecialization;
            Character.Strength = CharacterCreationManager.CreationMaster.CharacterData.CharacterAttributes.Strength;
            Character.Stamina = CharacterCreationManager.CreationMaster.CharacterData.CharacterAttributes.Stamina;
            Character.Endurance = CharacterCreationManager.CreationMaster.CharacterData.CharacterAttributes.Endurance;
            Character.Intellect = CharacterCreationManager.CreationMaster.CharacterData.CharacterAttributes.Intellect;
            Character.Agility = CharacterCreationManager.CreationMaster.CharacterData.CharacterAttributes.Agility;

            SelectFemaleGenderCommand = new SelectFemaleGenderCommand();
            SelectMaleGenderCommand = new SelectMaleGenderCommand();
            SelectNextAvatarCommand = new SelectNextAvatarCommand();
            SelectPreviousAvatarCommand = new SelectPreviousAvatarCommand();
            SelectRogueClassCommand = new LambdaCommands(OnSelectRogueClassCommandExecuted, CanSelectRogueClassCommandExecute);
            SelectWarriorClassCommand = new SelectWarriorClassCommand();
            SelectMageClassCommand = new SelectMageClassCommand();
        }

        private bool CanSelectRogueClassCommandExecute(object p) => true;
        private void OnSelectRogueClassCommandExecuted(object p)
        {
            CharacterCreationManager.CreationMaster.SelectSpecialization(2);
            OnPropertyChanged();
        }

    }
}
