using GameEngine.LevelUpMechanics.Services;
using GameEngine.Player;
using GameOfFrameworks.Models.Armory.AttributesControl;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.Models.UISkillsCollection.Player;
using GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces;
using GameOfFrameworks.Models.UISkillsCollection.Player.Services;
using GameOfFrameworks.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Windows;

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
        public int SkillSelectionIndex { get => _SkillSelectionIndex; set { Set(ref _SkillSelectionIndex, value); SelectSkill(value); } }
        public int AvailableSkillPoints { get => _AvailableSkillPoints; set => Set(ref _AvailableSkillPoints, value); }
        public int AvailableAttributesPoints { get => _AvailableAttributesPoints; set => Set(ref _AvailableAttributesPoints, value); }
        public LevelUpAttributesModel Attributes { get => _Attributes; set => Set(ref _Attributes, value); }
        private ObservableCollection<ISkillView> _AvailableSkills;
        public ObservableCollection<ISkillView> AvailableSkills { get => _AvailableSkills; set => Set(ref _AvailableSkills, value); }
        public ISkillView SelectedSkill { get => _SelectedSkill; set => Set(ref _SelectedSkill, value); }
        public Visibility SkillDescriptionBarVisibility { get => _SkillDescriptionBarVisibility; set => Set(ref _SkillDescriptionBarVisibility, value); }
        private PlayerAttributesLevelUpService LevelUpService { get; set; }
        public LevelUpViewModel()
        {
            SkillDescriptionBarVisibility = Visibility.Hidden;
            var skillToSkillViewConverter = new SkillToSkillViewConverter(ArmoryTemporaryData.PlayerModel.Specialization);

            AvailableSkillPoints = ArmoryTemporaryData.SaveData.AvailableSkillPoints;
            AvailableAttributesPoints = ArmoryTemporaryData.SaveData.AvailableAttributePoints;
            var skillLevelingListBuilder = new SkillLevelingListBuilder();
            var skillList = skillLevelingListBuilder.GetDefaultSkillList(ArmoryTemporaryData.SaveData.Specialization);
            var validatedSkillList = skillLevelingListBuilder.ValidateLevels(skillList, ArmoryTemporaryData.SaveData.PlayerSkills.Skills);
            AvailableSkills = skillToSkillViewConverter.ConvertRangeToObservableCollection(validatedSkillList);
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
    }
}
