using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Timers;

namespace GameOfFrameworks.Models.Services
{
    public class AnimatedProgressBar : INotifyPropertyChanged
    {
        private string _Brush;
        private double _Thickness;
        private Timer AnimationTimer;
        private Timer ThicknessAnimationTimer;
        private bool IsAnimationInProcess;
        private int _Value;
        private int UpdatedValue;
        public int Value { get => _Value; set { Animate(value); } }
        public double Thickness { get => _Thickness; set { _Thickness = value; OnPropertyChanged(); } }
        public string Brush { get => _Brush; set { _Brush = value; OnPropertyChanged(); } }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        public AnimatedProgressBar()
        {
            Brush = "Black";
            Thickness = 2;
        }
        private void Animate(int value)
        {
            if (value < _Value)
            {
                RestartTimer();
            }
            if (IsAnimationInProcess) return;
            UpdatedValue = value;
            InitializeAnimationTimer();
            IsAnimationInProcess = true;
        }

        private void AnimationTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (_Value < UpdatedValue)
            {
                _Value++;
                if (Thickness < 2.5)
                {
                    Thickness += 0.1;
                }
                OnPropertyChanged(nameof(Value));
            }
            else
            {
                AnimationTimer.Stop();
                ReturnThicknessToDefault();
                IsAnimationInProcess = false;
            }
        }
        private void RestartTimer()
        {
            _Value = 0;
            OnPropertyChanged(nameof(_Value));
            InitializeAnimationTimer();
        }
        private void InitializeAnimationTimer()
        {
            if (AnimationTimer is null)
            {
                AnimationTimer = new Timer(25);
                AnimationTimer.Elapsed += AnimationTimer_Elapsed;
            }
            AnimationTimer.Start();
        }
        private void ReturnThicknessToDefault()
        {
            if (ThicknessAnimationTimer is null)
            {
                ThicknessAnimationTimer = new Timer(25);
                ThicknessAnimationTimer.Elapsed += ThicknessAnimationTimer_Elapsed;
            }
            ThicknessAnimationTimer.Start();
        }

        private void ThicknessAnimationTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (Thickness == 2)
            {
                ThicknessAnimationTimer.Stop();
            }
            else Thickness -= 0.1;
        }
    }
}
