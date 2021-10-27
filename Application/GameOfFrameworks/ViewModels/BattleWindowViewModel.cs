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

namespace GameOfFrameworks.ViewModels
{
    public class BattleWindowViewModel : ViewModel
    {
        private Visibility _SkillDescriptionVisibility;
        private ISkillView _SelectedSkill;
        private ISkillEffectView _SelectedSkillEffect;
        private PlayerBarView _NPCBar;
        private PlayerBarView _PlayerBar;
        private readonly BattleMaster Master;
        private readonly ValuesObserver Observer;
        private readonly SkillEffectObserver EffectsObserver;
        private readonly SpecialAbilitiesObserverService AbilitiesObserverService;
        public Visibility SkillDescriptionVisibility { get => _SkillDescriptionVisibility; set { _SkillDescriptionVisibility = value; OnPropertyChanged(); } }
        public PlayerBarView NPCBar { get => _NPCBar; set { _NPCBar = value; OnPropertyChanged(); } }
        public PlayerBarView PlayerBar { get => _PlayerBar; set { _PlayerBar = value; OnPropertyChanged(); } }
        public ISkillView SelectedSkill { get => _SelectedSkill; set { _SelectedSkill = value; OnPropertyChanged(); } }
        public ISkillEffectView SelectedSkillEffect { get => _SelectedSkillEffect; set { _SelectedSkillEffect = value; OnPropertyChanged(); } }
        public CombatTextListBox CombatText { get; set; } = new();
        public ShortcutsListModel SkillShortcuts { get; set; }
        public EffectsListModel Effects { get; set; } = new();
        public ICommand BackToArmoryCommand { get; private set; }
        public ICommand UseSkillCommand { get; private set; }
        public ICommand SelectSkillByIndexCommand { get; private set; }
        public ICommand SetSelectedSkillCommand { get; private set; }
        public ICommand HideSkillDescriptionCommand { get; private set; }
        public ICommand SelectSkillFromSelectedSkillEffectCommand { get; private set; }
        public BattleWindowViewModel()
        {
            SkillShortcuts = ArmoryTemporaryData.SkillsShortcuts;
            Effects.Initialize(SkillShortcuts.SkillViewList);
            Master = new BattleMaster(ArmoryTemporaryData.SaveData);
            EffectsObserver = new SkillEffectObserver(ArmoryTemporaryData.SaveData);
            AbilitiesObserverService = new SpecialAbilitiesObserverService(Master.PlayerCombatManager.Dealer, ArmoryTemporaryData.PlayerSkills.Skills);
            PlayerBar = new PlayerBarView(Master.PlayerCombatManager.Dealer, Master.Observers[0].Player1Level, Master.Observers[0].DealerName);
            NPCBar = new PlayerBarView(Master.PlayerCombatManager.Target, Master.Observers[0].Player2Level, Master.Observers[0].TargetName.ToString().Replace("_", " "));
            Observer = new ValuesObserver(PlayerBar, NPCBar);
            Master.StartFight();
            Observer.Start();

            foreach (var item in Master.Observers)
            {
                item.Log += Notification;
            }
            BackToArmoryCommand = new BackToArmoryCommand(this);
            UseSkillCommand = new UseSkillCommand(this);
            SelectSkillByIndexCommand = new SelectSkillByIndexCommand(this);
            SetSelectedSkillCommand = new SetSelectedSkillCommand(this);
            HideSkillDescriptionCommand = new HideSkillDescriptionCommand(this);
            SelectSkillFromSelectedSkillEffectCommand = new SelectSkillFromSelectedSkillEffectCommand(this);
            SkillDescriptionVisibility = Visibility.Hidden;
        }

        private void Notification(string message)
        {
            Application.Current.Dispatcher.BeginInvoke(
                System.Windows.Threading.DispatcherPriority.Background,
                new Action(() =>
                {
                    CombatText.AddMessage(message.Replace("_", " "));
                }));
            PlayerBar.UpdateValues();
            NPCBar.UpdateValues();
        }
        public PlayerEntity GetPlayerEntity() => Master.PlayerCombatManager.Dealer;
        public void UseSkillByIndex(int skillIndex) => Master.UseSkill(skillIndex);
        public int GetSkillIndex(int ID)
        {
            int count = 0;

            foreach (var item in Master.SkillList)
            {
                if (item.Skill_ID == ID)
                {
                    return count;
                }
                else
                {
                    count++;
                }
            }
            return count;
        }
        public void StopFight() => Master.StopFight();
    }
}
