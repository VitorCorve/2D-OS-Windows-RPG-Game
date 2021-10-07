using GameEngine.CombatEngine;
using GameEngine.EquipmentManagement;
using GameEngine.Player;
using GameOfFrameworks.Infrastructure.Commands.Armory;
using GameOfFrameworks.Infrastructure.Commands.Armory.Attributes;
using GameOfFrameworks.Infrastructure.Commands.Armory.LevelUp;
using GameOfFrameworks.Models.Armory.AttributesControl;
using GameOfFrameworks.Models.Armory.Interfaces;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces;
using GameOfFrameworks.Models.UISkillsCollection.Player.Services;
using GameOfFrameworks.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels
{
    public class AttributesControlViewModel : ViewModel, ISkillListViewModel
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
        public static ICommand UpdateAttributesViewModelCommand { get; private set; }
        public static ICommand UpdateAttributesViewModelAvailableSkillsCommand { get; private set; }
        public ICommand SelectItemFromSkillViewListCommand { get; private set; }
        public ICommand CancelItemSelectionFromSkillViewListCommand { get; private set; }
        public ICommand SetupCapturedSkillToShortcutCommand { get; private set; }
        public ICommand CancelShortcutFocusCommand { get; private set; }
        public ICommand CloseShortcutPopupCommand { get; private set; }
        public static ICommand UpdateShortcutsCommand { get; private set; }
        public static ICommand SortSkillsCommand { get; private set; }
        public AttributesControlViewModel()
        {
            DescriptionBarVisibility = Visibility.Hidden;

            var skillToSkillViewConverter = new SkillToSkillViewConverter(ArmoryTemporaryData.PlayerModel.Specialization);
            AvailableSkills = skillToSkillViewConverter.ConvertRangeToObservableCollection(ArmoryTemporaryData.PlayerSkills.Skills);

            Shortcuts = new ShortcutsListModel();

            ArmoryTemporaryData.PlayerSkills = new PlayerSkillList();
            ArmoryTemporaryData.PlayerSkills.Skills = ArmoryTemporaryData.SaveData.PlayerSkills.Skills;

            SetupAttributes();

            Shortcuts.Initialize(skillToSkillViewConverter.ConvertRangeToObservableCollection(ArmoryTemporaryData.PlayerSkills.Skills));

            InitializeCommands();
        }
        private void InitializeCommands()
        {
            UpdateAttributesViewModelCommand = new UpdateAttributesViewModelCommand(this);
            SelectItemFromSkillViewListCommand = new SelectItemFromSkillViewListCommand(this);
            CancelItemSelectionFromSkillViewListCommand = new CancelItemSelectionFromSkillViewListCommand(this);
            SetupCapturedSkillToShortcutCommand = new SetupCapturedSkillToShortcutCommand(this);
            CancelShortcutFocusCommand = new CancelShortcutFocusCommand(this);
            CloseShortcutPopupCommand = new CloseShortcutPopupCommand(this);
            UpdateAttributesViewModelAvailableSkillsCommand = new UpdateAttributesViewModelAvailableSkillsCommand(this);
            UpdateShortcutsCommand = new UpdateShortcutsCommand(this);
            SortSkillsCommand = new SortSkillsCommand(this);
        }
        private void ValidateSkillDescriptionBar(ISkillView skillView)
        {
            if (skillView?.Skill is null) DescriptionBarVisibility = Visibility.Hidden;
            else DescriptionBarVisibility = Visibility.Visible;
        }
        private void SetupAttributes()
        {
            var playerEntityConstructor = new PlayerEntityConstructor();
            var equippmentValues = new EquipmentValue(ArmoryTemporaryData.PlayerEquipment);
            var playerEntity = playerEntityConstructor.CreatePlayer(ArmoryTemporaryData.PlayerModel, ArmoryTemporaryData.SaveData.PlayerAttributes, equippmentValues);
            Attributes = new AttributesModel(playerEntity, ArmoryTemporaryData.PlayerAttributes, equippmentValues);
        }
    }
}
