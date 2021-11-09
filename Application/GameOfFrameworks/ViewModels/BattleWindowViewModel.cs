using GalaSoft.MvvmLight.Command;
using GameEngine.BattleMaster;
using GameEngine.CombatEngine;
using GameEngine.CombatEngine.Actions;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Services;
using GameEngine.Experience;
using GameEngine.LootMaster;
using GameEngine.Player;
using GameEngine.SpecializationMechanics.Services;
using GameOfFrameworks.ApplicationData;
using GameOfFrameworks.Infrastructure.Commands.BattleScene;
using GameOfFrameworks.Models.Armory.AttributesControl;
using GameOfFrameworks.Models.Armory.EquipmentControl;
using GameOfFrameworks.Models.BattleScene;
using GameOfFrameworks.Models.BattleScene.Services;
using GameOfFrameworks.Models.Services;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.Models.UISkillsCollection.Player;
using GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces;
using GameOfFrameworks.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace GameOfFrameworks.ViewModels
{
    public class BattleWindowViewModel : ViewModel
    {
        private delegate void Function();
        private Visibility _SkillDescriptionVisibility;
        private Visibility _LootItemBarVisibility;
        private Visibility _LootBarVisibility;
        private ISkillView _SelectedSkill;
        private PlayerBarModel _NPCBar;
        private PlayerBarModel _PlayerBar;
        private ObservableCollection<EquipmentUserInterfaceViewTemplate> _LootList;
        private EquipmentUserInterfaceViewTemplate _SelectedItem;
        private Dictionary<string, string> _ItemDescription;
        private PlayerConsumablesData _MoneyReward;
        private readonly ValuesObserver Observer;
        private readonly SkillEffectObserver EffectsObserver;
        private readonly SpecialAbilitiesObserverService AbilitiesObserverService;
        private readonly CombatTextMessageCreator MessageCreator;
        private LootMaster Loot;
        private ExperienceMaster Experience;
        public Visibility SkillDescriptionVisibility { get => _SkillDescriptionVisibility; set { _SkillDescriptionVisibility = value; OnPropertyChanged(); } }
        public Visibility LootItemBarVisibility { get => _LootItemBarVisibility; set { _LootItemBarVisibility = value; OnPropertyChanged(); } }
        public Visibility LootBarVisibility { get => _LootBarVisibility; set { _LootBarVisibility = value; OnPropertyChanged(); } }
        public PlayerBarModel NPCBar { get => _NPCBar; set { _NPCBar = value; OnPropertyChanged(); } }
        public PlayerBarModel PlayerBar { get => _PlayerBar; set { _PlayerBar = value; OnPropertyChanged(); } }
        public ISkillView SelectedSkill { get => _SelectedSkill; set { _SelectedSkill = value; OnPropertyChanged(); } }
        public CombatTextListBox CombatText { get; set; } = new();
        public ShortcutsListModel SkillShortcuts { get; set; }
        public EffectsListModel Effects { get; set; } = new();
        public BattleMaster Master { get; set; }
        public CharacterPreviewBarModel PlayerPreviewBar { get; set; }
        public CharacterPreviewBarModel NPCPreviewBar { get; set; }
        public string BackgroundImagePath { get; set; } = BattleSceneBackgroundSelector.GetPath();
        public CharacterPreviewBarAnimationManager PlayerPreviewBarAnimationManager { get; set; }
        public CharacterPreviewBarAnimationManager NPCPreviewBarAnimationManager { get; set; }
        public ObservableCollection<EquipmentUserInterfaceViewTemplate> LootList { get => _LootList; set { _LootList = value; OnPropertyChanged(); } }
        public EquipmentUserInterfaceViewTemplate SelectedItem { get => _SelectedItem; set { _SelectedItem = value; CreateItemDescription(); ChangeItemDescriptionVisibility(); OnPropertyChanged(); } }
        public Dictionary<string, string> ItemDescription { get => _ItemDescription; set => Set(ref _ItemDescription, value); }
        public PlayerConsumablesData MoneyReward { get => _MoneyReward; set { _MoneyReward = value; OnPropertyChanged(); } }
        public KeyboardBindingsModel Bindings { get; set; }
        public int SelectedItemIndex { get; set; }
        public ICommand BackToArmoryCommand { get; private set; }
        public static ICommand UseSkillCommand { get; private set; }
        public ICommand SelectSkillByIndexCommand { get; private set; }
        public ICommand SetSelectedSkillCommand { get; private set; }
        public ICommand HideSkillDescriptionCommand { get; private set; }
        public ICommand SelectSkillFromSelectedSkillEffectCommand { get; private set; }
        public ICommand ShowAttributesControlCommand { get; private set; }
        public ICommand HideAttributesControlCommand { get; private set; }
        public ICommand HideLootItemBarVisibilityCommand { get; private set; }
        public ICommand CloseLootBarCommand { get; private set; }
        public ICommand PickUpItemCommand { get; private set; }
        public ICommand RecognizeKeyDownCommand { get; private set; }
        public BattleWindowViewModel()
        {
            CooldownEraser.Clean(ArmoryTemporaryData.PlayerSkills.Skills);

            SkillShortcuts = ArmoryTemporaryData.SkillsShortcuts;
            Effects.Initialize(SkillShortcuts.SkillViewList);

            Master = new BattleMaster(ArmoryTemporaryData.SaveData);

            EffectsObserver = new SkillEffectObserver(ArmoryTemporaryData.SaveData);
            AbilitiesObserverService = new SpecialAbilitiesObserverService(Master.PlayerCombatManager.Dealer, ArmoryTemporaryData.PlayerSkills.Skills);

            PlayerBar = new PlayerBarModel(Master.PlayerCombatManager.Dealer, Master.Observers[0].Player1Level, Master.Observers[0].DealerName, ArmoryTemporaryData.SaveData.AvatarPath.Path, ArmoryTemporaryData.SaveData.AvatarPath.MiniaturePath);
            NPCBar = new PlayerBarModel(Master.PlayerCombatManager.Target, Master.Observers[0].Player2Level, Master.Observers[0].TargetName.ToString().Replace("_", " "), Master.GetNPCModel().Avatar.Path, Master.GetNPCModel().Avatar.MiniaturePath);

            PlayerPreviewBar = new CharacterPreviewBarModel(Master.PlayerCombatManager.Dealer, ArmoryTemporaryData.PlayerAttributes, ArmoryTemporaryData.PlayerModel);
            NPCPreviewBar = new CharacterPreviewBarModel(Master.PlayerCombatManager.Target, Master.GetNPCEntity(), Master.GetNPCModel());
            Experience = new();

            Observer = new ValuesObserver(PlayerBar, NPCBar);

            foreach (var item in Master.Observers)
                item.Log += Notification;

            InitializeCommands();

            SkillDescriptionVisibility = Visibility.Hidden;

            // do not forget to change 14th line in BackToArmoryCommand

            MessageCreator = new(Master.GetNPCModel().Avatar.MiniaturePath);

            PlayerPreviewBarAnimationManager = new CharacterPreviewBarAnimationManager(PlayerPreviewBar, SERVICE_OWNER.Player);
            NPCPreviewBarAnimationManager = new CharacterPreviewBarAnimationManager(NPCPreviewBar, SERVICE_OWNER.Enemy);

            Loot = new LootMaster(ArmoryTemporaryData.PlayerModel.PlayerGrade, ArmoryTemporaryData.PlayerInventory, ArmoryTemporaryData.PlayerModel.PlayerConsumables);

            LootItemBarVisibility = Visibility.Hidden;
            LootBarVisibility = Visibility.Hidden;
            Master.BattleFinished += ExperienceGain;
            ArmoryTemporaryData.PlayerModel.NewLevelGainded += LevelUp;
            Master.BattleFinished += PrepareLoot;

            Bindings = new();

            BattleWindowTemporaryData.ViewModel = this;
            BattleWindowTemporaryData.IsActive = true;
        }
        private void Notification(ACTION_TYPE actionType, string message, SERVICE_OWNER owner, ISkill skill = null)
        {
            Application.Current.Dispatcher.BeginInvoke(
                System.Windows.Threading.DispatcherPriority.Background,
                new Action(() =>
                {
                    if (actionType == ACTION_TYPE.Experience)
                        CombatText.AddMessage(MessageCreator.Create(actionType, message, owner, skill), delayed: true, 50);
                    if (actionType == ACTION_TYPE.LevelUp)
                        CombatText.AddMessage(MessageCreator.Create(actionType, message, owner, skill), delayed: true, 100);
                    else
                        CombatText.AddMessage(MessageCreator.Create(actionType, message, owner, skill));
                }));
        }
        public PlayerEntity GetPlayerEntity() => Master.PlayerCombatManager.Dealer;
        public void UseSkillByIndex(int skillIndex) => Master.UseSkill(skillIndex);
        private void CreateItemDescription()
        {
            if (SelectedItem is null) return;
            var itemDescriptionBuilder = new ItemDescriptionBuilder();
            ItemDescription = itemDescriptionBuilder.Build(ItemEntityConverter.ConvertToItemEntity(SelectedItem));
        }
        private void ChangeItemDescriptionVisibility()
        {
            if (SelectedItem is null) LootItemBarVisibility = Visibility.Hidden;
            else LootItemBarVisibility = Visibility.Visible;
        }
        private void InitializeCommands()
        {
            BackToArmoryCommand = new BackToArmoryCommand(this);
            UseSkillCommand = new UseSkillCommand(this);
            SelectSkillByIndexCommand = new SelectSkillByIndexCommand(this);
            SetSelectedSkillCommand = new SetSelectedSkillCommand(this);
            HideSkillDescriptionCommand = new HideSkillDescriptionCommand(this);
            SelectSkillFromSelectedSkillEffectCommand = new SelectSkillFromSelectedSkillEffectCommand(this);
            HideAttributesControlCommand = new HideAttributesControlCommand(this);
            ShowAttributesControlCommand = new ShowAttributesControlCommand(this);
            HideLootItemBarVisibilityCommand = new HideLootItemBarVisibilityCommand(this);
            RecognizeKeyDownCommand = new RecognizeKeyDownCommand();
            CloseLootBarCommand = new RelayCommand(() => LootBarVisibility = Visibility.Hidden);
            PickUpItemCommand = new RelayCommand(PickUpItem);
        }
        private void PrepareLoot()
        {
            LootBarVisibility = Visibility.Visible;
            Loot.ThrowItems();
            MoneyReward = new PlayerConsumablesData(Loot.MoneyReward);
            var itemEntityConverter = new ItemEntityConverter();
            LootList = itemEntityConverter.ConvertRangeToObservableCollection(Loot.Loot);
        }
        private void PickUpItem()
        {
            Loot.PickUpItem(SelectedItemIndex);
            MainWindowViewModel.ShowNotificationCommand.Execute($"{SelectedItem.ItemName} added to inventory");
            ArmoryTemporaryData.PlayerInventory = Loot.Inventory;
            ArmoryTemporaryData.PlayerModel.PlayerConsumables = new PlayerConsumablesData(ArmoryTemporaryData.PlayerModel.PlayerConsumables.AbsoluteMoneyValue + MoneyReward.AbsoluteMoneyValue);
            ArmoryViewModel.SaveGameCommand.Execute(true);
            LootList = null;
            var itemEntityConverter = new ItemEntityConverter();
            LootList = itemEntityConverter.ConvertRangeToObservableCollection(Loot.Loot);
            LootItemBarVisibility = Visibility.Hidden;
        }
        private void ExperienceGain()
        {
            ArmoryTemporaryData.PlayerModel = Experience.AddExperience(ArmoryTemporaryData.PlayerModel, Master.GetNPCModel());
            Notification(ACTION_TYPE.Experience, $"{ Experience.Value} experience gained", SERVICE_OWNER.Player);
        }
        private void LevelUp()
        {
            Notification(ACTION_TYPE.LevelUp, "New level gained", SERVICE_OWNER.Player);
            PlayerBar.Level++;
        }
    }
}