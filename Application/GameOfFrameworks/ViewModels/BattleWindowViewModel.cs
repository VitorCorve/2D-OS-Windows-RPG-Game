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
using System.Timers;
using System.Windows;
using System.Windows.Input;
using System.Linq;

namespace GameOfFrameworks.ViewModels
{
    public class BattleWindowViewModel : ViewModel
    {
        private PlayerBarView _NPCBar;
        private PlayerBarView _PlayerBar;
        public PlayerBarView NPCBar { get => _NPCBar; set { _NPCBar = value; OnPropertyChanged(); } }
        public PlayerBarView PlayerBar { get => _PlayerBar; set { _PlayerBar = value; OnPropertyChanged(); } }
        private readonly BattleMaster Master;
        private readonly ValuesObserver Observer;
        private readonly SkillEffectObserver EffectsObserver;
        private readonly SpecialAbilitiesObserverService AbilitiesObserverService;
        public ICommand BackToArmoryCommand { get; private set; }
        public ICommand UseSkillCommand { get; private set; }
        public CombatTextListBox CombatText { get; set; } = new();
        public ShortcutsListModel SkillShortcuts { get; set; }
        public BattleWindowViewModel()
        {
            SkillShortcuts = ArmoryTemporaryData.SkillsShortcuts;
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
        public void Action(int skillIndex) => Master.UseSkill(skillIndex);
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
