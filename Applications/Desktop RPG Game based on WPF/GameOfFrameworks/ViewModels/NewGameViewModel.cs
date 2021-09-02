using GameEngine.CharacterCreationMaster;
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

        private CharacterCreationData _CreationData;
        public CharacterCreationData CreationData 
        { 
            get => _CreationData; 
            set
            {
                _CreationData = value;
                OnPropertyChanged();
            }
        }
        public CharacterCreationMaster CreationMaster { get; private set; } = new();
        public NewGameViewModel()
        {
            CreationData = new CharacterCreationData();
            CreationMaster = new CharacterCreationMaster();

            SelectFemaleGenderCommand = new SelectFemaleGenderCommand();
            SelectMaleGenderCommand = new SelectMaleGenderCommand();
            SelectNextAvatarCommand = new SelectNextAvatarCommand();
            SelectPreviousAvatarCommand = new SelectPreviousAvatarCommand();
            SelectRogueClassCommand = new LambdaCommands(OnSelectRogueClassCommandExecuted, CanSelectRogueClassCommandExecute);
            SelectWarriorClassCommand = new LambdaCommands(OnSelectWarriorClassCommandExecuted, CanSelectWarriorClassCommandExecute);
            SelectMageClassCommand = new LambdaCommands(OnSelectMageClassCommandExecuted, CanSelectMageClassCommandExecute);
            SelectAttributeDescriptionCommand = new LambdaCommands(OnSelectAttributeDescriptionCommand, CanSelectAtrributeDescriptionCommand);

            CreationMaster.SelectSpecialization(0);
            CreationData = CreationMaster.CharacterData;

            CreationMaster.SelectAttributeDescription(0);
            SelectedAttributeDescription = CreationData.AttributeDescription;
        }

        private bool CanSelectRogueClassCommandExecute(object p) => true;
        private void OnSelectRogueClassCommandExecuted(object p)
        {
            CreationMaster.SelectSpecialization(2);
            CreationData = CreationMaster.CharacterData;
        }
        private bool CanSelectMageClassCommandExecute(object p) => true;
        private void OnSelectMageClassCommandExecuted(object p)
        {
            CreationMaster.SelectSpecialization(1);
            CreationData = CreationMaster.CharacterData;
        }
        private bool CanSelectWarriorClassCommandExecute(object p) => true;
        private void OnSelectWarriorClassCommandExecuted(object p)
        {
            CreationMaster.SelectSpecialization(0);
            CreationData = CreationMaster.CharacterData;
        }
        private bool CanSelectAtrributeDescriptionCommand(object p) => true;
        private void OnSelectAttributeDescriptionCommand(object p)
        {

        }
    }
}
