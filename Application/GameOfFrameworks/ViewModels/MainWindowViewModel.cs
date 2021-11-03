using GameOfFrameworks.ApplicationData;
using GameOfFrameworks.ApplicationData.Services;
using GameOfFrameworks.Infrastructure.Commands.MainWindow;
using GameOfFrameworks.Models.Services;
using GameOfFrameworks.ViewModels.Base;
using System.Windows;
using System.Windows.Input;

namespace GameOfFrameworks.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        private ConsoleCommandsList _CommandsList;
        private ConsoleCommandsList _ConsoleNotificationsList;
        private Visibility _NotifyVisibility;
        private Visibility _ConsoleVisibility;
        private string _NotifyMessage;
        private string _ConsoleNotifyMessage;
        private string _ConsoleCommand;
        private double _SaveGameNotifyOpacity;
        private bool _IsConsoleTextBoxFocused;
        public string Version { get; }
        public ConsoleCommandsList ConsoleNotificationsList { get => _ConsoleNotificationsList; set => Set(ref _ConsoleNotificationsList, value); }
        public ConsoleCommandsList CommandsList { get => _CommandsList; set => Set(ref _CommandsList, value); }
        public static ApplicationSettings Settings { get; set; }
        public Visibility NotifyVisibility { get => _NotifyVisibility; set => Set(ref _NotifyVisibility, value); }
        public Visibility ConsoleVisibility { get => _ConsoleVisibility; set => Set(ref _ConsoleVisibility, value); }
        public string NotifyMessage { get => _NotifyMessage; set => Set(ref _NotifyMessage, value); }
        public string ConsoleNotifyMessage { get => _ConsoleNotifyMessage; set => Set(ref _ConsoleNotifyMessage, value); }
        public string ConsoleCommand { get => _ConsoleCommand; set => Set(ref _ConsoleCommand, value); }
        public double SaveGameNotifyOpacity { get => _SaveGameNotifyOpacity; set => Set(ref _SaveGameNotifyOpacity, value); }
        public static ICommand ShowNotificationCommand { get; private set; }
        public static ICommand SelectNextWindowModeCommand { get; private set; }
        public static ICommand SelectPreviousWindowModeCommand { get; private set; }
        public static ICommand SelectNextDisplayResolutionCommand { get; private set; }
        public static ICommand SelectPreviousDisplayResolutionCommand { get; private set; }
        public static ICommand SaveApplicationSettingsCommand { get; private set; }
        public static ICommand SetConsoleMessageCommand { get; private set; }
        public ICommand EngageConsole { get; private set; }
        public ICommand ShowPreviousConsoleCommand { get; private set; }
        public ICommand ShowNextConsoleCommand { get; private set; }
        public ICommand ExecuteConsoleCommand { get; private set; }
        public int ConsoleCommandSelectionIndex { get; set; }
        public int ConsoleCommandCount { get; set; }
        public bool IsConsoleTextBoxFocused { get => _IsConsoleTextBoxFocused; set => Set(ref _IsConsoleTextBoxFocused, value); }
        public MainWindowViewModel()
        {
            Version = "1.1.1.2";

            var settingsHandlerService = new SettingsHandlerService();
            Settings = settingsHandlerService.Load();

            ShowNotificationCommand = new ShowNotificationCommand(this);
            EngageConsole = new EngageConsole(this);
            ExecuteConsoleCommand = new ExecuteConsoleCommand(this);
            SetConsoleMessageCommand = new SetConsoleMessageCommand(this);
            ShowPreviousConsoleCommand = new ShowPreviousConsoleCommand(this);
            ShowNextConsoleCommand = new ShowNextConsoleCommand(this);
            SelectNextWindowModeCommand = new SelectNextWindowModeCommand();
            SelectPreviousWindowModeCommand = new SelectPreviousWindowModeCommand();
            SelectNextDisplayResolutionCommand = new SelectNextDisplayResolutionCommand();
            SelectPreviousDisplayResolutionCommand = new SelectPreviousDisplayResolutionCommand();
            SaveApplicationSettingsCommand = new SaveApplicationSettingsCommand();

            NotifyVisibility = Visibility.Hidden;
            ConsoleVisibility = Visibility.Hidden;

            ConsoleNotificationsList = new ConsoleCommandsList();
            CommandsList = new ConsoleCommandsList();
        }
    }
}
