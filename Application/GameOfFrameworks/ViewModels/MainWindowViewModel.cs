using GameOfFrameworks.Infrastructure.Commands.MainWindow;
using GameOfFrameworks.Infrastructure.UserApplicationSettings;
using GameOfFrameworks.ViewModels.Base;
using System;
using System.Windows;
using System.Windows.Input;

namespace GameOfFrameworks.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        private Visibility _SaveGameNotifyVisibility;
        private double _SaveGameNotifyOpacity;
        public string Version { get; }
        public int HorizontalWindowResolution { get; set; }
        public int VerticalWindowResolution { get; set; }
        public string WindowStyle { get; set; }
        public string WindowState { get; set; }
        public Visibility SaveGameNotifyVisibility { get => _SaveGameNotifyVisibility; set => Set(ref _SaveGameNotifyVisibility, value); }
        public double SaveGameNotifyOpacity { get => _SaveGameNotifyOpacity; set => Set(ref _SaveGameNotifyOpacity, value); }
        public static ICommand ShowSaveGameNotificationCommand { get; private set; }
        public MainWindowViewModel()
        {
            Version = "1.1.0.6";
            var videoSettings = new GameVideoSettings();
            HorizontalWindowResolution = videoSettings.HorizontalVideoResolution;
            VerticalWindowResolution = videoSettings.VerticalVideoResolution;
            WindowStyle = videoSettings.UserWindowStyleSetting;
            WindowState = videoSettings.UserWindowStateSetting;

            ShowSaveGameNotificationCommand = new ShowSaveGameNotificationCommand(this);

            SaveGameNotifyVisibility = Visibility.Hidden;
        }
    }
}
