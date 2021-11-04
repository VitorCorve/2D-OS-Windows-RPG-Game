using GameEngine.BattleMaster;
using GameEngine.CombatEngine;
using GameEngine.CombatEngine.Services;
using GameOfFrameworks.Infrastructure.Commands.BattleScene;
using GameOfFrameworks.Models.Armory.AttributesControl;
using GameOfFrameworks.Models.BattleScene;
using GameOfFrameworks.Models.BattleScene.Services;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels.Base;
using System;
using System.Windows;
using System.Windows.Input;
using GameOfFrameworks.Models.UISkillsCollection.Player;
using GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Actions;
using GameOfFrameworks.Models.Services;
using GameEngine.LootMaster;
using System.Collections.ObjectModel;
using GameOfFrameworks.Models.Armory.EquipmentControl;
using System.Collections.Generic;

namespace GameOfFrameworks.ViewModels
{
    public class BattleWindowViewModel : ViewModel
    {
        private Visibility _SkillDescriptionVisibility;
        private ISkillView _SelectedSkill;
        private ISkillEffectView _SelectedSkillEffect;
        private PlayerBarModel _NPCBar;
        private PlayerBarModel _PlayerBar;
        private ObservableCollection<EquipmentUserInterfaceViewTemplate> _LootList;
        private EquipmentUserInterfaceViewTemplate _SelectedItem;
        private Dictionary<string, string> _ItemDescription;
        private readonly ValuesObserver Observer;
        private readonly SkillEffectObserver EffectsObserver;
        private readonly SpecialAbilitiesObserverService AbilitiesObserverService;
        private readonly CombatTextMessageCreator MessageCreator;
        private readonly LootMaster Loot;
        public Visibility SkillDescriptionVisibility { get => _SkillDescriptionVisibility; set { _SkillDescriptionVisibility = value; OnPropertyChanged(); } }
        public PlayerBarModel NPCBar { get => _NPCBar; set { _NPCBar = value; OnPropertyChanged(); } }
        public PlayerBarModel PlayerBar { get => _PlayerBar; set { _PlayerBar = value; OnPropertyChanged(); } }
        public ISkillView SelectedSkill { get => _SelectedSkill; set { _SelectedSkill = value; OnPropertyChanged(); } }
        public ISkillEffectView SelectedSkillEffect { get => _SelectedSkillEffect; set { _SelectedSkillEffect = value; OnPropertyChanged(); } }
        public CombatTextListBox CombatText { get; set; } = new();
        public ShortcutsListModel SkillShortcuts { get; set; }
        public EffectsListModel Effects { get; set; } = new();
        public BattleMaster Master { get; set; }
        public CharacterPreviewBarModel PlayerPreviewBar { get; set; }
        public CharacterPreviewBarModel NPCPreviewBar { get; set; }
        public string BackgroundImagePath { get; set; }
        public ICommand BackToArmoryCommand { get; private set; }
        public ICommand UseSkillCommand { get; private set; }
        public ICommand SelectSkillByIndexCommand { get; private set; }
        public ICommand SetSelectedSkillCommand { get; private set; }
        public ICommand HideSkillDescriptionCommand { get; private set; }
        public ICommand SelectSkillFromSelectedSkillEffectCommand { get; private set; }
        public ICommand ShowAttributesControlCommand { get; private set; }
        public ICommand HideAttributesControlCommand { get; private set; }
        public CharacterPreviewBarAnimationManager PlayerPreviewBarAnimationManager { get; set; }
        public CharacterPreviewBarAnimationManager NPCPreviewBarAnimationManager { get; set; }
        public ObservableCollection<EquipmentUserInterfaceViewTemplate> LootList { get => _LootList; set { _LootList = value; OnPropertyChanged(); } }
        public EquipmentUserInterfaceViewTemplate SelectedItem { get => _SelectedItem; set { _SelectedItem = value; CreateItemDescription(); OnPropertyChanged(); } }
        public Dictionary<string, string> ItemDescription { get => _ItemDescription; set => Set(ref _ItemDescription, value); }
        public BattleWindowViewModel()
        {
            BackgroundImagePath = BattleSceneBackgroundSelector.GetPath();
            var saveData = ArmoryTemporaryData.SaveData;
            var skills = ArmoryTemporaryData.PlayerSkills.Skills;

            SkillShortcuts = ArmoryTemporaryData.SkillsShortcuts;
            Effects.Initialize(SkillShortcuts.SkillViewList);

            Master = new BattleMaster(saveData);
            var player = Master.PlayerCombatManager.Dealer;
            var enemy = Master.PlayerCombatManager.Target;
            var playerLevel = Master.Observers[0].Player1Level;
            var playerName = Master.Observers[0].DealerName;
            var playerAvatar = ArmoryTemporaryData.SaveData.AvatarPath;
            var enemyLevel = Master.Observers[0].Player2Level;
            var enemyName = Master.Observers[0].TargetName.ToString().Replace("_", " ");
            var enemyAvatar = Master.GetNPCModel().Avatar;

            EffectsObserver = new SkillEffectObserver(saveData);
            AbilitiesObserverService = new SpecialAbilitiesObserverService(player, skills);

            PlayerBar = new PlayerBarModel(player, playerLevel, playerName, playerAvatar.Path, playerAvatar.MiniaturePath);
            NPCBar = new PlayerBarModel(enemy, enemyLevel, enemyName, enemyAvatar.Path, enemyAvatar.MiniaturePath);

            PlayerPreviewBar = new CharacterPreviewBarModel(player, ArmoryTemporaryData.PlayerAttributes, ArmoryTemporaryData.PlayerModel);
            NPCPreviewBar = new CharacterPreviewBarModel(enemy, Master.GetNPCEntity(), Master.GetNPCModel());

            Observer = new ValuesObserver(PlayerBar, NPCBar);

            //Master.StartFight();

            Observer.Start();

            foreach (var item in Master.Observers)
            {
                item.Log += Notification;
            }
            InitializeCommands();

            SkillDescriptionVisibility = Visibility.Hidden;

            // do not forget to change 14th line in BackToArmoryCommand
            // cooldowns didn't dissapear after game exit

            MessageCreator = new(enemyAvatar.MiniaturePath);

            PlayerPreviewBarAnimationManager = new CharacterPreviewBarAnimationManager(PlayerPreviewBar, SERVICE_OWNER.Player);
            NPCPreviewBarAnimationManager = new CharacterPreviewBarAnimationManager(NPCPreviewBar, SERVICE_OWNER.Enemy);

            Loot = new LootMaster(ArmoryTemporaryData.PlayerModel.PlayerGrade, ArmoryTemporaryData.PlayerInventory, ArmoryTemporaryData.PlayerModel.PlayerConsumables);
            Loot.ThrowItems();
            var itemEntityConverter = new ItemEntityConverter();
            LootList = itemEntityConverter.ConvertRangeToObservableCollection(Loot.Loot);
        }
        private void Notification(ACTION_TYPE actionType, string message, SERVICE_OWNER owner, ISkill skill)
        {
            Application.Current.Dispatcher.BeginInvoke(
                System.Windows.Threading.DispatcherPriority.Background,
                new Action(() =>
                {
                    CombatText.AddMessage(MessageCreator.Create(actionType, message, owner, skill));
                }));
            PlayerBar.UpdateValues();
            NPCBar.UpdateValues();
        }
        public PlayerEntity GetPlayerEntity() => Master.PlayerCombatManager.Dealer;
        public void UseSkillByIndex(int skillIndex) => Master.UseSkill(skillIndex);
        private void CreateItemDescription()
        {
            var itemDescriptionBuilder = new ItemDescriptionBuilder();
            ItemDescription = itemDescriptionBuilder.Build(ItemEntityConverter.ConvertToItemEntity(SelectedItem));
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

        }
    }
}
