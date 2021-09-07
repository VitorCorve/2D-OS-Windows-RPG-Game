using GameEngine.CharacterCreationMaster;
using GameEngine.CharacterCreationMaster.Services;
using GameEngine.Player;
using GameEngine.Player.ModelConditions;
using GameEngine.Player.Specializatons.Warrior;
using GameOfFrameworks.Infrastructure.Commands.CharacterCreation;
using GameOfFrameworks.Models.CharacterCreation;
using GameOfFrameworks.Models.CharacterCreation.Services;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels.Base;
using System.Collections.Generic;
using System.Windows.Input;

namespace GameOfFrameworks.ViewModels
{
    public class NewGameViewModel : ViewModel
    {
        public ICommand ConfirmCharacterCreationDataCommand { get; private set; }
        public ICommand SelectFemaleGenderCommand { get; private set; }
        public ICommand SelectMaleGenderCommand { get; private set; }
        public ICommand SelectNextAvatarCommand { get; private set; }
        public ICommand SelectPreviousAvatarCommand { get; private set; }
        public ICommand SelectRogueClassCommand { get; private set; }
        public ICommand SelectWarriorClassCommand { get; private set; }
        public ICommand SelectMageClassCommand { get; private set; }
        public ICommand UpdateDataCommand { get; private set; }
        public ICommand SelectStrengthDescriptionCommand { get; private set; }
        public ICommand SelectStaminaDescriptionCommand { get; private set; }
        public ICommand SelectEnduranceDescriptionCommand { get; private set; }
        public ICommand SelectIntellectDescriptionCommand { get; private set; }
        public ICommand SelectAgilityDescriptionCommand { get; private set; }
        public string SelectedAttributeDescription { get; private set; }
        private CharacterCreationData _CharacterData;
        public CharacterCreationData CharacterData { get => _CharacterData; set { _CharacterData = value; OnPropertyChanged(); } }

        private int _AvatarSelectionValue;
        public int AvatarSelectionValue { get => _AvatarSelectionValue; set => ConvertValues(value); }
        public CharacterSpecializationDescription SpecializationDescription { get; set; } = new();
        public List<PlayerAvatar> AvatarsList { get; set; } = new();
        public NewGameViewModel()
        {
            if (NewGameCharacterTemporaryData.PlayerModel != null)
            {
                LoadTemporaryData();
                InitializeCommands();
                return;
            }

            InitializeCharacterData();
            InitialiizeCharacterBio();
            InitializeAttributesDescription();
            InitializePlayerAvatars();
            InitializeCommands();
        }
        private void ConvertValues(int value)
        {
            if (value > 9)
            {
                _AvatarSelectionValue = 0;
                return;
            }
            if (value < 0)
            {
                _AvatarSelectionValue = 9;
                return;
            }
            _AvatarSelectionValue = value;
        }
        private void InitializeCommands()
        {
            SelectRogueClassCommand = new SelectRogueClassCommand(CharacterData, this);
            SelectMageClassCommand = new SelectMageClassCommand(CharacterData, this);
            SelectWarriorClassCommand = new SelectWarriorClassCommand(CharacterData, this);
            SelectMaleGenderCommand = new SelectMaleGenderCommand(CharacterData, this);
            SelectFemaleGenderCommand = new SelectFemaleGenderCommand(CharacterData, this);
            SelectStrengthDescriptionCommand = new SelectStrengthDescriptionCommand(CharacterData, this);
            SelectStaminaDescriptionCommand = new SelectStaminaDescriptionCommand(CharacterData, this);
            SelectEnduranceDescriptionCommand = new SelectEnduranceDescriptionCommand(CharacterData, this);
            SelectIntellectDescriptionCommand = new SelectIntellectDescriptionCommand(CharacterData, this);
            SelectAgilityDescriptionCommand = new SelectAgilityDescriptionCommand(CharacterData, this);
            SelectNextAvatarCommand = new SelectNextAvatarCommand(CharacterData, this);
            SelectPreviousAvatarCommand = new SelectPreviousAvatarCommand(CharacterData, this);
            ConfirmCharacterCreationDataCommand = new ConfirmCharacterCreationDataCommand(CharacterData, this);
        }
        private void InitializePlayerAvatars()
        {
            var avatarsData = new GetAvatarsData();
            AvatarsList = avatarsData.GetAvatarsList(CharacterData.CharacterSpecialization, CharacterData.Gender);
            CharacterData.AvatarPath = new PlayerAvatarPath(AvatarsList[AvatarSelectionValue].Path);
        }
        private void InitializeAttributesDescription()
        {
            CharacterData.AttributeDescription = CharacterData.AttributesDescriptionList[0];
            SpecializationDescription.SetDescription(CharacterData.CharacterSpecialization);
        }
        private void LoadTemporaryData()
        {
            AvatarSelectionValue = NewGameCharacterTemporaryData.AvatarSelectionValue;
            var convertPlayerModelToCharacterCreationData = new ConvertPlayerModelToCharacterCreationData();
            CharacterData = convertPlayerModelToCharacterCreationData.Convert(NewGameCharacterTemporaryData.PlayerModel);
            AvatarsList = CharacterData.PlayerAvatarsList;
            SpecializationDescription = NewGameCharacterTemporaryData.SpecializationDescription;
            SelectedAttributeDescription = CharacterData.AttributeDescription;
        }
        private void InitializeCharacterData()
        {
            CharacterData = new CharacterCreationData();
            CharacterData.CharacterAttributes = new EntityModel_Warrior();
            CharacterData.Name = "Debug";
        }
        private void InitialiizeCharacterBio()
        {
            CharacterData.Bio = new PlayerBiography();
            CharacterData.Bio.Value = "Stranger from the lonesome road.";
        }
    }
}
