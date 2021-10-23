using GameEngine.CombatEngine.Interfaces.SkillMechanics;
using GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Timers;
using System.Windows;

namespace GameOfFrameworks.Models.UISkillsCollection.Player
{
    public class SkillEffectView : ISkillEffectView, INotifyPropertyChanged
    {
        private readonly double Duration;
        private readonly double Cooldown;
        private Visibility _CooldownStatement;
        private Visibility _DurationStatement;
        private bool IDurationInterface;
        private double _DurationCount;
        private double _CooldownCount;
        public int ID { get; set; }
        public double DurationCount { get => _DurationCount; set { _DurationCount = value; OnPropertyChanged(); } }
        public double CooldownCount { get => _CooldownCount; set { _CooldownCount = value; OnPropertyChanged(); } }
        public Visibility CooldownStatement { get => _CooldownStatement; set { _CooldownStatement = value; OnPropertyChanged(); } }
        public Visibility DurationStatement { get => _DurationStatement; set { _DurationStatement = value; OnPropertyChanged(); } }
        public string ImagePath { get; set; }
        public Timer DurationTimer { get; set; }
        public Timer CooldownTimer { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public SkillEffectView() { }
        public SkillEffectView(ISkillView skillView)
        {
            CooldownStatement = Visibility.Hidden;
            DurationStatement = Visibility.Hidden;

            if (skillView.Skill is null)
            {
                return;
            }
            ID = skillView.Skill.Skill_ID;

            if (skillView.Skill is ISkillDuration)
            {
                Duration = ((ISkillDuration)skillView.Skill).Duration;
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
                DurationCount = Cooldown;
                DurationStatement = Visibility.Hidden;
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
        }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
