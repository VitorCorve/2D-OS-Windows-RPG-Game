using GameEngine.LevelUpMechanics.Services;
using GameEngine.Player;
using GameOfFrameworks.Infrastructure.Commands.Armory.LevelUp;
using GameOfFrameworks.Models.Armory.AttributesControl;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces;
using GameOfFrameworks.Models.UISkillsCollection.Player.Services;
using GameOfFrameworks.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels
{
    public class LevelUpViewModel : ViewModel
    {
        private int _SkillSelectionIndex;
        private int _AvailableSkillPoints;
        private int _AvailableAttributesPoints;
        private LevelUpAttributesModel _Attributes;
        private ISkillView _SelectedSkill;
        private Visibility _SkillDescriptionBarVisibility;
        private bool _IsAttributeLevelUpAvailable;
        private bool _IsSkilLevelUpAvailable;
        private double _AttributesLevelUpButtonsOpacity;
        public int SkillSelectionIndex { get => _SkillSelectionIndex; set { Set(ref _SkillSelectionIndex, value); SelectSkill(value); } }
        public int AvailableSkillPoints { get => _AvailableSkillPoints; set { Set(ref _AvailableSkillPoints, value); ValidateSkillLevelingOpportunity(); } }
        public int AvailableAttributesPoints { get => _AvailableAttributesPoints; set { Set(ref _AvailableAttributesPoints, value); ValidateAttributesLevelingOpportunity(); } }
        public LevelUpAttributesModel Attributes { get => _Attributes; set => Set(ref _Attributes, value); }
        private ObservableCollection<ISkillView> _AvailableSkills;
        public ObservableCollection<ISkillView> AvailableSkills { get => _AvailableSkills; set => Set(ref _AvailableSkills, value); }
        public ISkillView SelectedSkill { get => _SelectedSkill; set => Set(ref _SelectedSkill, value); }
        public Visibility SkillDescriptionBarVisibility { get => _SkillDescriptionBarVisibility; set => Set(ref _SkillDescriptionBarVisibility, value); }
        public PlayerConsumablesData PlayerConsumables { get; set; }
        public static ICommand UpdatePlayerAttributeCommand { get; private set; }
        public static ICommand UpdatePlayerSkillCommand { get; private set; }
        public bool IsAttributeLevelUpAvailable { get => _IsAttributeLevelUpAvailable; set => Set(ref _IsAttributeLevelUpAvailable,  value); }
        public bool IsSkilLevelUpAvailable { get => _IsSkilLevelUpAvailable; set => Set(ref _IsSkilLevelUpAvailable, value); }
        public double AttributesLevelUpButtonsOpacity { get => _AttributesLevelUpButtonsOpacity; set => Set(ref _AttributesLevelUpButtonsOpacity, value); }


        public LevelUpViewModel()
        {
            SkillDescriptionBarVisibility = Visibility.Hidden;
            var skillToSkillViewConverter = new SkillToSkillViewConverter(ArmoryTemporaryData.PlayerModel.Specialization);

            PlayerConsumables = ArmoryTemporaryData.PlayerModel.PlayerConsumables;
            PlayerConsumables.AttributePointsValue.Value = 10;
            PlayerConsumables.SkillPointsValue.Value = 10;

            Attributes = new LevelUpAttributesModel(ArmoryTemporaryData.SaveData.PlayerAttributes);
            AvailableSkillPoints = PlayerConsumables.SkillPointsValue.Value;
            AvailableAttributesPoints = PlayerConsumables.AttributePointsValue.Value;
            var skillLevelingListBuilder = new SkillLevelingListBuilder();
            var skillList = skillLevelingListBuilder.GetDefaultSkillList(ArmoryTemporaryData.SaveData.Specialization);
            var validatedSkillList = skillLevelingListBuilder.ValidateLevels(skillList, ArmoryTemporaryData.SaveData.PlayerSkills.Skills);
            AvailableSkills = skillToSkillViewConverter.ConvertRangeToObservableCollection(validatedSkillList);

            InitializeCommands();
            ValidateSkillsLevelUpPreparedness();
        }
        private void SelectSkill(int index)
        {
            if (index >= 0)
            {
                SelectedSkill = AvailableSkills[index];
                SkillDescriptionBarVisibility = Visibility.Visible;
            }
            else SkillDescriptionBarVisibility = Visibility.Hidden;
        }
        private void ValidateAttributesLevelingOpportunity()
        {
            if (AvailableAttributesPoints > 0)
            {
                AttributesLevelUpButtonsOpacity = 1;
                IsAttributeLevelUpAvailable = true;
            }
            else
            {
                AttributesLevelUpButtonsOpacity = 0.4;
                IsAttributeLevelUpAvailable = false;
            }
        }
        private void ValidateSkillLevelingOpportunity()
        {
            if (AvailableSkills is null) return;

            if (AvailableSkillPoints <= 0)
            {
                foreach (var skillView in AvailableSkills)
                    skillView.Disable();
            }
            else ValidateSkillsLevelUpPreparedness();
        }
        private void ValidateSkillsLevelUpPreparedness()
        {
            foreach (var skill in AvailableSkills)
            {
                skill.PlayerLevel = ArmoryTemporaryData.SaveData.Level + 10;
                skill.CheckIsLevelUpReady();
            }
        }
        private void InitializeCommands()
        {
            UpdatePlayerAttributeCommand = new UpdatePlayerAttributeCommand(this);
            UpdatePlayerSkillCommand = new UpdatePlayerSkillCommand(this);
        }
    }
}
