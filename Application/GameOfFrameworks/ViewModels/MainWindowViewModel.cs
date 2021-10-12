using GameOfFrameworks.ApplicationData;
using GameOfFrameworks.ApplicationData.Services;
using GameOfFrameworks.Infrastructure.Commands.MainWindow;
using GameOfFrameworks.ViewModels.Base;
using System.Windows;
using System.Windows.Input;

namespace GameOfFrameworks.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        private Visibility _NotifyVisibility;
        private string _NotifyMessage;
        private double _SaveGameNotifyOpacity;
        public string Version { get; }
        public static ApplicationSettings Settings { get; set; }
        public Visibility NotifyVisibility { get => _NotifyVisibility; set => Set(ref _NotifyVisibility, value); }
        public string NotifyMessage { get => _NotifyMessage; set => Set(ref _NotifyMessage, value); }
        public double SaveGameNotifyOpacity { get => _SaveGameNotifyOpacity; set => Set(ref _SaveGameNotifyOpacity, value); }
        public static ICommand ShowNotificationCommand { get; private set; }
        public static ICommand SelectNextWindowModeCommand { get; private set; }
        public static ICommand SelectPreviousWindowModeCommand { get; private set; }
        public static ICommand SelectNextDisplayResolutionCommand { get; private set; }
        public static ICommand SelectPreviousDisplayResolutionCommand { get; private set; }
        public static ICommand SaveApplicationSettingsCommand { get; private set; }
        public MainWindowViewModel()
        {
            Version = "1.1.0.8";

            var settingsHandlerService = new SettingsHandlerService();
            Settings = settingsHandlerService.Load();

            ShowNotificationCommand = new ShowNotificationCommand(this);
            SelectNextWindowModeCommand = new SelectNextWindowModeCommand();
            SelectPreviousWindowModeCommand = new SelectPreviousWindowModeCommand();
            SelectNextDisplayResolutionCommand = new SelectNextDisplayResolutionCommand();
            SelectPreviousDisplayResolutionCommand = new SelectPreviousDisplayResolutionCommand();
            SaveApplicationSettingsCommand = new SaveApplicationSettingsCommand();

            NotifyVisibility = Visibility.Hidden;
        }
    }
}
