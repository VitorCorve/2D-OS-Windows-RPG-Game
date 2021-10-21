using GameEngine.BattleMaster;
using GameEngine.CombatEngine.Services;
using GameOfFrameworks.Models.BattleScene;
using GameOfFrameworks.Models.BattleScene.Services;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels.Base;
using System;
using System.Timers;
using System.Windows;

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
        public CombatTextListBox CombatText { get; set; } = new();
        public BattleWindowViewModel()
        {
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
        }

        private void Notification(string message)
        {
            Application.Current.Dispatcher.BeginInvoke(
                System.Windows.Threading.DispatcherPriority.Background,
                new Action(() =>
                {
                    CombatText.AddMessage(message);
                }));
            PlayerBar.UpdateValues();
            NPCBar.UpdateValues();
        }
    }
}
