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
using System.Collections.Generic;
using GameEngine.CombatEngine.Interfaces;
using System.Timers;
using GameEngine.CombatEngine.Actions;
using GameOfFrameworks.Models.Services;
using GameOfFrameworks.Models.UISkillsCollection.Player.Services;
using GameEngine.SpecializationMechanics.UniversalSkills;

namespace GameOfFrameworks.ViewModels
{
    public class BattleWindowViewModel : ViewModel
    {
        private Visibility _SkillDescriptionVisibility;
        private ISkillView _SelectedSkill;
        private ISkillEffectView _SelectedSkillEffect;
        private PlayerBarView _NPCBar;
        private PlayerBarView _PlayerBar;
        private readonly ValuesObserver Observer;
        private readonly SkillEffectObserver EffectsObserver;
        private readonly SpecialAbilitiesObserverService AbilitiesObserverService;
        private readonly CombatTextMessageCreator MessageCreator;
        private List<ISkill> _SkillsList;
        public Visibility SkillDescriptionVisibility { get => _SkillDescriptionVisibility; set { _SkillDescriptionVisibility = value; OnPropertyChanged(); } }
        public PlayerBarView NPCBar { get => _NPCBar; set { _NPCBar = value; OnPropertyChanged(); } }
        public PlayerBarView PlayerBar { get => _PlayerBar; set { _PlayerBar = value; OnPropertyChanged(); } }
        public ISkillView SelectedSkill { get => _SelectedSkill; set { _SelectedSkill = value; OnPropertyChanged(); } }
        public ISkillEffectView SelectedSkillEffect { get => _SelectedSkillEffect; set { _SelectedSkillEffect = value; OnPropertyChanged(); } }
        public CombatTextListBox CombatText { get; set; } = new();
        public ShortcutsListModel SkillShortcuts { get; set; }
        public EffectsListModel Effects { get; set; } = new();
        public BattleMaster Master { get; set; }
        public List<ISkill> SkillsList { get => _SkillsList; set { _SkillsList = value; OnPropertyChanged(); } }
        public ICommand BackToArmoryCommand { get; private set; }
        public ICommand UseSkillCommand { get; private set; }
        public ICommand SelectSkillByIndexCommand { get; private set; }
        public ICommand SetSelectedSkillCommand { get; private set; }
        public ICommand HideSkillDescriptionCommand { get; private set; }
        public ICommand SelectSkillFromSelectedSkillEffectCommand { get; private set; }
        public BattleWindowViewModel()
        {
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

            EffectsObserver = new SkillEffectObserver(saveData);
            AbilitiesObserverService = new SpecialAbilitiesObserverService(player, skills);

            PlayerBar = new PlayerBarView(player, playerLevel, playerName, playerAvatar.Path, playerAvatar.MiniaturePath);
            NPCBar = new PlayerBarView(enemy, enemyLevel, enemyName, playerAvatar.Path, playerAvatar.MiniaturePath);

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
            SkillsList = skills;

            var timer = new Timer(20);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

            MessageCreator = new();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Application.Current.Dispatcher.BeginInvoke(
            System.Windows.Threading.DispatcherPriority.Background,
                new Action(() =>
            {
                SkillsList = null;
                SkillsList = ArmoryTemporaryData.PlayerSkills.Skills;
                OnPropertyChanged(nameof(SkillsList));
            }));
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
        private void InitializeCommands()
        {
            BackToArmoryCommand = new BackToArmoryCommand(this);
            UseSkillCommand = new UseSkillCommand(this);
            SelectSkillByIndexCommand = new SelectSkillByIndexCommand(this);
            SetSelectedSkillCommand = new SetSelectedSkillCommand(this);
            HideSkillDescriptionCommand = new HideSkillDescriptionCommand(this);
            SelectSkillFromSelectedSkillEffectCommand = new SelectSkillFromSelectedSkillEffectCommand(this);
        }
    }
}
