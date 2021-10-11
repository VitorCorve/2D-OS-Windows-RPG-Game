using GameOfFrameworks.Infrastructure.Commands.Armory.Options;
using GameOfFrameworks.ViewModels.Base;
using System.Windows;
using System.Windows.Input;

namespace GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels.Options
{
    public class OptionsControlViewModel : ViewModel
    {
        private Visibility _GameplayOptionsControlVisibility;
        private Visibility _OptionsMenuControlVisibility;
        private Visibility _SaveGameControlVisibility;
        private Visibility _LoadGameControlVisibility;
        private Visibility _LeaveGameConfirmationControlVisibility;
        public Visibility OptionsMenuControlVisibility { get => _OptionsMenuControlVisibility; set => Set(ref _OptionsMenuControlVisibility, value); }
        public Visibility SaveGameControlVisibility { get => _SaveGameControlVisibility; set => Set(ref _SaveGameControlVisibility, value); }
        public Visibility LoadGameControlVisibility { get => _LoadGameControlVisibility; set => Set(ref _LoadGameControlVisibility, value); }
        public Visibility GameplayOptionsControlVisibility { get => _GameplayOptionsControlVisibility; set => Set(ref _GameplayOptionsControlVisibility, value); }
        public Visibility LeaveGameConfirmationControlVisibility { get => _LeaveGameConfirmationControlVisibility; set => Set(ref _LeaveGameConfirmationControlVisibility, value); }
        public static ICommand ShowSaveGameControlCommand { get; private set; }
        public static ICommand ShowLoadGameControlCommand { get; private set; }
        public static ICommand ShowOptionsControlCommand { get; private set; }
        public static ICommand ShowGameplayOptionsControlCommand { get; private set; }
        public static ICommand ShowExitGameControlCommand { get; private set; }
        public static ICommand ShowConfirmMoveToMainMenuControlCommand { get; private set; }
        public static ICommand HideLeaveGameConfirmationControlCommand { get; private set; }
        public static ICommand ExecuteTemporaryCommand { get; private set; }
        public ICommand TemporaryCommand { get; set; }
        public OptionsControlViewModel()
        {
            SaveGameControlVisibility = Visibility.Hidden;
            LoadGameControlVisibility = Visibility.Hidden;
            LeaveGameConfirmationControlVisibility = Visibility.Hidden;
            InitializeCommands();
        }
        public void HideControls()
        {
            OptionsMenuControlVisibility = Visibility.Hidden;
            GameplayOptionsControlVisibility = Visibility.Hidden;
            SaveGameControlVisibility = Visibility.Hidden;
            LoadGameControlVisibility = Visibility.Hidden;
            LeaveGameConfirmationControlVisibility = Visibility.Hidden;
        }
        private void InitializeCommands()
        {
            ShowSaveGameControlCommand = new ShowSaveGameControlCommand(this);
            ShowLoadGameControlCommand = new ShowLoadGameControlCommand(this);
            ShowOptionsControlCommand = new ShowOptionsControlCommand(this);
            ShowGameplayOptionsControlCommand = new ShowGameplayOptionsControlCommand(this);
            ShowExitGameControlCommand = new ShowExitGameControlCommand(this);
            ShowConfirmMoveToMainMenuControlCommand = new ShowConfirmMoveToMainMenuControlCommand(this);
            HideLeaveGameConfirmationControlCommand = new HideLeaveGameConfirmationControlCommand(this);
            ExecuteTemporaryCommand = new ExecuteTemporaryCommand(this);
        }
    }
}
