using GameEngine.CharacterCreationMaster;
using GameEngine.CharacterCreationMaster.Services;
using GameEngine.Player;
using GameEngine.Player.ModelConditions;
using GameEngine.Player.Specializatons.Warrior;
using GameOfFrameworks.Infrastructure.Commands.CharacterCreation;
using GameOfFrameworks.Models.CharacterCreation;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels.Base;
using System.Collections.Generic;
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
        public ICommand SelectStrengthDescriptionCommand { get; }
        public ICommand SelectStaminaDescriptionCommand { get; }
        public ICommand SelectEnduranceDescriptionCommand { get; }
        public ICommand SelectIntellectDescriptionCommand { get; }
        public ICommand SelectAgilityDescriptionCommand { get; }
        public string SelectedAttributeDescription { get; }
        private CharacterCreationData _CharacterData;
        public CharacterCreationData CharacterData { get => _CharacterData; set { _CharacterData = value; OnPropertyChanged(); } }

        private int _AvatarSelectionValue;
        public int AvatarSelectionValue { get => _AvatarSelectionValue; set => ConvertValues(value); }
        public CharacterSpecializationDescription SpecializationDescription { get; set; } = new();
        public List<PlayerAvatar> AvatarsList { get; set; } = new();
        public NewGameViewModel()
        {
            CharacterData = new CharacterCreationData();
            CharacterData.CharacterAttributes = new EntityModel_Warrior();

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

            CharacterData.AttributeDescription = CharacterData.AttributesDescriptionList[0];

            var avatarsData = new GetAvatarsData();
            AvatarsList = avatarsData.GetAvatarsList(CharacterData.CharacterSpecialization, CharacterData.Gender);
            CharacterData.AvatarPath = new PlayerAvatarPath(AvatarsList[AvatarSelectionValue].Path);

            SpecializationDescription.SetDescription(CharacterData.CharacterSpecialization);

            CharacterData.Bio = new PlayerBiography();
            CharacterData.Bio.Value = "Stranger from the lonesome road.";
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
    }
}
