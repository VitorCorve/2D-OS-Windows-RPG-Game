using GalaSoft.MvvmLight.Command;
using GameOfFrameworks.ViewModels.Base;
using System.Windows;
using System.Windows.Input;

namespace GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels.Options
{
    public class VideoSettingsControlViewModel : ViewModel
    {
        private int _Height;
        private int _Width;
        private bool _CanChangeResolution;
        private double _ChangingResolutionControlsOpacity;
        public int Height { get => _Height; set { _Height = value; OnPropertyChanged(); } }
        public int Width { get => _Width; set { _Width = value; OnPropertyChanged(); } }
        private string _WindowState;
        public string WindowState { get => _WindowState; set { _WindowState = value; OnPropertyChanged(); } }
        public bool CanChangeResolution { get => _CanChangeResolution; set { _CanChangeResolution = value; OnPropertyChanged(); } }
        public double ChangingResolutionControlsOpacity { get => _ChangingResolutionControlsOpacity; set { _ChangingResolutionControlsOpacity = value; OnPropertyChanged(); } }
        public ICommand SelectNextWindowModeCommand { get; private set; }
        public ICommand SelectPreviousWindowModeCommand { get; private set; }
        public ICommand SelectNextResolutionCommand { get; private set; }
        public ICommand SelectPreviousResolutionCommand { get; private set; }
        public VideoSettingsControlViewModel()
        {
            SelectNextWindowModeCommand = new RelayCommand(SetNextWindowStyle);
            SelectPreviousWindowModeCommand = new RelayCommand(SetPreviousWindowStyle);
            SelectNextResolutionCommand = new RelayCommand(SetNextDisplayResolution);
            SelectPreviousResolutionCommand = new RelayCommand(SetPreviousDisplayResolution);
            DisplayWindowState();
            DisplayDisplayResolutionState();
        }
        private void SetNextDisplayResolution()
        {
            MainWindowViewModel.SelectNextDisplayResolutionCommand.Execute(null);
            DisplayDisplayResolutionState();
        }
        private void SetPreviousDisplayResolution()
        {
            MainWindowViewModel.SelectPreviousDisplayResolutionCommand.Execute(null);
            DisplayDisplayResolutionState();
        }
        private void SetNextWindowStyle()
        {
            MainWindowViewModel.SelectNextWindowModeCommand.Execute(null);
            DisplayWindowState();
        }
        private void SetPreviousWindowStyle()
        {
            MainWindowViewModel.SelectPreviousWindowModeCommand.Execute(null);
            DisplayWindowState();
        }
        private void DisplayWindowState()
        {
            if (MainWindowViewModel.Settings.WindowStyle.Style == WindowStyle.SingleBorderWindow)
            {
                WindowState = "Bordered";
                CanChangeResolution = true;
                ChangingResolutionControlsOpacity = 1.0;
            }
            else
            {
                WindowState = "Fullscreen";
                CanChangeResolution = false;
                ChangingResolutionControlsOpacity = 0.3;
            }
        }
        private void DisplayDisplayResolutionState()
        {
            Width = MainWindowViewModel.Settings.Resolution.Width;
            Height = MainWindowViewModel.Settings.Resolution.Height;
        }
    }
}
