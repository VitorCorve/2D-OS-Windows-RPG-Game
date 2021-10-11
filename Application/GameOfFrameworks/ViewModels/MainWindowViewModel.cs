using GameOfFrameworks.Infrastructure.Commands.MainWindow;
using GameOfFrameworks.Infrastructure.UserApplicationSettings;
using GameOfFrameworks.ViewModels.Base;
using System.Windows;
using System.Windows.Input;

namespace GameOfFrameworks.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        private int _HorizontalWindowResolution;
        private WindowStyle _WindowStyle;
        private WindowState _WindowState;
        private Visibility _SaveGameNotifyVisibility;
        private double _SaveGameNotifyOpacity;
        public string Version { get; }
        public int HorizontalWindowResolution { get => _HorizontalWindowResolution; set => Set(ref _HorizontalWindowResolution, value); }
        public int VerticalWindowResolution { get; set; }
        public WindowStyle WindowStyle { get => _WindowStyle; set => Set(ref _WindowStyle, value); }
        public WindowState WindowState { get => _WindowState; set => Set(ref _WindowState, value); }
        public Visibility SaveGameNotifyVisibility { get => _SaveGameNotifyVisibility; set => Set(ref _SaveGameNotifyVisibility, value); }
        public double SaveGameNotifyOpacity { get => _SaveGameNotifyOpacity; set => Set(ref _SaveGameNotifyOpacity, value); }
        public static ICommand ShowSaveGameNotificationCommand { get; private set; }
        public static ICommand SetWindowModeWindowedCommand { get; private set; }
        public MainWindowViewModel()
        {
            WindowState = WindowState.Maximized;
            Version = "1.1.0.6";
            var videoSettings = new GameVideoSettings();
            HorizontalWindowResolution = videoSettings.HorizontalVideoResolution;
            VerticalWindowResolution = videoSettings.VerticalVideoResolution;
            /*            WindowStyle = videoSettings.UserWindowStyleSetting;
                        WindowState = videoSettings.UserWindowStateSetting;*/


            ShowSaveGameNotificationCommand = new ShowSaveGameNotificationCommand(this);
            SetWindowModeWindowedCommand = new SetWindowModeWindowedCommand(this);

            SaveGameNotifyVisibility = Visibility.Hidden;
        }
    }
}
