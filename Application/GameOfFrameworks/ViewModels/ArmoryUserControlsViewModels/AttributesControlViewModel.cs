using GameOfFrameworks.Infrastructure.Commands.Armory;
using GameOfFrameworks.Infrastructure.Commands.Armory.Attributes;
using GameOfFrameworks.Models.Armory.AttributesControl;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.Models.UISkillsCollection.Player;
using GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces;
using GameOfFrameworks.Models.UISkillsCollection.Player.Services;
using GameOfFrameworks.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels
{
    public class AttributesControlViewModel : ViewModel
    {
        private ShortcutsListModel _Shortcuts;
        private ISkillView _SelectedSkill;
        private ISkillView _MouseCapturedSkill;
        private int _MouseCapturedShortcutIndex;
        private AttributesModel _Attributes;
        private ObservableCollection<ISkillView> _AvailableSkills;
        private bool _PopupShortcutIsOpen;
        private Visibility _DescriptionBarVisibility;
        public AttributesModel Attributes { get => _Attributes; set => Set(ref _Attributes, value); }
        public ObservableCollection<ISkillView> AvailableSkills { get => _AvailableSkills; set => Set(ref _AvailableSkills, value); }
        public ISkillView SelectedSkill { get => _SelectedSkill; set { _SelectedSkill = value; OnPropertyChanged(); ValidateSkillDescriptionBar(value); } }
        public ISkillView MouseCapturedSkill { get => _MouseCapturedSkill; set => Set(ref _MouseCapturedSkill, value); }
        public int MouseCapturedShortCutIndex { get => _MouseCapturedShortcutIndex; set => Set(ref _MouseCapturedShortcutIndex, value); }
        public ShortcutsListModel Shortcuts { get => _Shortcuts; set => Set(ref _Shortcuts, value); }
        public bool PopupShortcutIsOpen { get => _PopupShortcutIsOpen; set => Set(ref _PopupShortcutIsOpen, value); }
        public Visibility DescriptionBarVisibility { get => _DescriptionBarVisibility; set => Set(ref _DescriptionBarVisibility, value); }
        public ICommand UpdateAttributesCommand { get; private set; }
        public ICommand SelectItemFromSkillViewListCommand { get; private set; }
        public ICommand CancelItemSelectionFromSkillViewListCommand { get; private set; }
        public ICommand SetupCapturedSkillToShortcutCommand { get; private set; }
        public ICommand CancelShortcutFocusCommand { get; private set; }
        public ICommand CloseShortcutPopupCommand { get; private set; }
        public AttributesControlViewModel()
        {
            DescriptionBarVisibility = Visibility.Hidden;
            var skillViewBuilder = new SkillViewBuilder(ArmoryTemporaryData.PlayerModel);

            var skillToSkillViewConverter = new SkillToSkillViewConverter(ArmoryTemporaryData.PlayerModel.Specialization);
            AvailableSkills = skillViewBuilder.BuildObservableCollection();

            foreach (var item in AvailableSkills)
            {
                item.Skill.SkillLevel = 1;
            }
            Shortcuts = new ShortcutsListModel();
            Shortcuts.Initialize(skillToSkillViewConverter.ConvertRangeToObservableCollection(ArmoryTemporaryData.SaveData.Skills.Skills));

            UpdateAttributesCommand = new UpdateAttributesCommand(this);
            SelectItemFromSkillViewListCommand = new SelectItemFromSkillViewListCommand(this);
            CancelItemSelectionFromSkillViewListCommand = new CancelItemSelectionFromSkillViewListCommand(this);
            SetupCapturedSkillToShortcutCommand = new SetupCapturedSkillToShortcutCommand(this);
            CancelShortcutFocusCommand = new CancelShortcutFocusCommand(this);
            CloseShortcutPopupCommand = new CloseShortcutPopupCommand(this);
        }
        private void ValidateSkillDescriptionBar(ISkillView skillView)
        {
            if (skillView?.Skill is null) DescriptionBarVisibility = Visibility.Hidden;
            else DescriptionBarVisibility = Visibility.Visible;
        }
    }
}
