using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Interfaces.SkillMechanics;
using GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Timers;
using System.Windows;

namespace GameOfFrameworks.Models.UISkillsCollection.Player
{
    public class SkillEffectView : ISkillEffectView, INotifyPropertyChanged
    {
        private readonly GrowingEffectsListView BuffsList;
        private readonly GrowingEffectsListView DebuffsList;
        private readonly double Duration;
        private readonly double Cooldown;
        private readonly bool IDurationInterface;
        private readonly bool IDebuffSkill;
        private readonly bool IBuffSkill;
        private Visibility _CooldownStatement;
        private Visibility _DurationStatement;
        private double _DurationCount;
        private double _CooldownCount;
        private ISkillView _SkillView;
        public int ID { get; set; }
        public double DurationCount { get => _DurationCount; set { _DurationCount = value; OnPropertyChanged(); } }
        public double CooldownCount { get => _CooldownCount; set { _CooldownCount = value; OnPropertyChanged(); } }
        public Visibility CooldownStatement { get => _CooldownStatement; set { _CooldownStatement = value; OnPropertyChanged(); } }
        public Visibility DurationStatement { get => _DurationStatement; set { _DurationStatement = value; OnPropertyChanged(); } }
        public ISkillView SkillView { get => _SkillView; set { _SkillView = value; OnPropertyChanged(); } }
        public string ImagePath { get; set; }
        public Timer DurationTimer { get; set; }
        public Timer CooldownTimer { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public SkillEffectView()
        {
            CooldownStatement = Visibility.Hidden;
            DurationStatement = Visibility.Hidden;
        }
        public SkillEffectView(ISkillView skillView, GrowingEffectsListView buffsList, GrowingEffectsListView debuffsList)
        {
            SkillView = skillView;
            BuffsList = buffsList;
            DebuffsList = debuffsList;

            CooldownStatement = Visibility.Hidden;
            DurationStatement = Visibility.Hidden;

            if (skillView.Skill is null)
            {
                return;
            }

            ID = skillView.Skill.Skill_ID;

            if (skillView.Skill is IDebuffSkill)
            {
                IDebuffSkill = true;
            }

            if (skillView.Skill is IBuffSkill)
            {
                IBuffSkill = true;
            }

            if (skillView.Skill is ISkillDuration duration)
            {
                Duration = duration.Duration;
                DurationTimer = new Timer(1000);
                DurationTimer.Elapsed += DurationTimer_Tick;
                IDurationInterface = true;
                DurationCount = Duration;
            }

            Cooldown = skillView.Skill.CoolDownDuration;
            CooldownTimer = new Timer(1000);
            CooldownTimer.Elapsed += CooldownTimer_Tick;
            CooldownCount = Cooldown;
            ImagePath = skillView.ImagePath;
        }
        private void CooldownTimer_Tick(object sender, ElapsedEventArgs e)
        {
            if (CooldownCount == 0)
            {
                CooldownTimer.Stop();
                CooldownCount = Cooldown;
                CooldownStatement = Visibility.Hidden;
            }
            else CooldownCount -= 1.0;
        }
        private void DurationTimer_Tick(object sender, ElapsedEventArgs e)
        {
            if (DurationCount == 0)
            {
                DurationTimer.Stop();
                DurationCount = Duration;
                DurationStatement = Visibility.Hidden;
                if (IDebuffSkill) Action(() => DebuffsList.RemoveFrom(ID));
                if (IBuffSkill) Action(() => BuffsList.RemoveFrom(ID));
            }
            else DurationCount -= 1.0;
        }
        public void Activate()
        {
            if (IDurationInterface)
            {
                DurationTimer.Start();
                DurationStatement = Visibility.Visible;
            }
            CooldownTimer.Start();
            CooldownStatement = Visibility.Visible;

            if (IDebuffSkill) DebuffsList.AddNew(this);
            if (IBuffSkill) BuffsList.AddNew(this);
        }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        public void Hide()
        {
            CooldownStatement = Visibility.Hidden;
            DurationStatement = Visibility.Hidden;
        }
        public void Show()
        {
            CooldownStatement = Visibility.Visible;
            DurationStatement = Visibility.Visible;
        }
        private void Action(Action func = null)
        {
            Application.Current.Dispatcher.BeginInvoke(
            System.Windows.Threading.DispatcherPriority.Background,
            new Action(() =>
            {
                func?.Invoke();
            }));
        }
    }
}
