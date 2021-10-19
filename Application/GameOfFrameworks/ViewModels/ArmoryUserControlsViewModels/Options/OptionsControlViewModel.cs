using GalaSoft.MvvmLight.Command;
using GameOfFrameworks.Infrastructure.Commands.Armory.Options;
using GameOfFrameworks.Models.Armory.Options;
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
        private Visibility _OverwriteControlVisibility;
        private Visibility _DeletingControlVisibility;
        private Visibility _LoadGameConfirmationControlVisibility;
        private GameSavePresentationList _SavesList;
        public Visibility OptionsMenuControlVisibility { get => _OptionsMenuControlVisibility; set => Set(ref _OptionsMenuControlVisibility, value); }
        public Visibility SaveGameControlVisibility { get => _SaveGameControlVisibility; set => Set(ref _SaveGameControlVisibility, value); }
        public Visibility LoadGameControlVisibility { get => _LoadGameControlVisibility; set => Set(ref _LoadGameControlVisibility, value); }
        public Visibility GameplayOptionsControlVisibility { get => _GameplayOptionsControlVisibility; set => Set(ref _GameplayOptionsControlVisibility, value); }
        public Visibility LeaveGameConfirmationControlVisibility { get => _LeaveGameConfirmationControlVisibility; set => Set(ref _LeaveGameConfirmationControlVisibility, value); }
        public Visibility OverwriteControlVisibility { get => _OverwriteControlVisibility; set => Set(ref _OverwriteControlVisibility, value); }
        public Visibility DeletingControlVisibility { get => _DeletingControlVisibility; set => Set(ref _DeletingControlVisibility, value); }
        public Visibility LoadGameConfirmationControlVisibility { get => _LoadGameConfirmationControlVisibility; set => Set(ref _LoadGameConfirmationControlVisibility, value); }
        public GameSavePresentationList SavesList { get => _SavesList; set => Set(ref _SavesList, value); }
        public static ICommand ShowSaveGameControlCommand { get; private set; }
        public static ICommand ShowLoadGameControlCommand { get; private set; }
        public static ICommand ShowOptionsControlCommand { get; private set; }
        public static ICommand ShowGameplayOptionsControlCommand { get; private set; }
        public static ICommand ShowExitGameControlCommand { get; private set; }
        public static ICommand ShowConfirmMoveToMainMenuControlCommand { get; private set; }
        public static ICommand HideLeaveGameConfirmationControlCommand { get; private set; }
        public static ICommand ExecuteTemporaryCommand { get; private set; }
        public static ICommand ConfirmSaveGameDeletingCommand { get; private set; }
        public static ICommand HideSaveDeletingControlCommand { get; private set; }
        public static ICommand ShowLoadingGameConfirmationControlCommand { get; private set; }
        public ICommand SaveSettingsCommand { get; set; }
        public ICommand TemporaryCommand { get; set; }
        public ICommand GameplayOverwriteSaveGameCommand { get; set; }
        public ICommand HideSavingOverwriteControlCommand { get; set; }
        public ICommand HideLoadingGameConfirmationControlCommand { get; set; }
        public ICommand SaveGameCommand { get; set; }
        public ICommand LoadGameCommand { get; set; }
        public ICommand DeleteSaveGameCommand { get; set; }
        public ICommand OverwriteSaveGameCommand { get; set; }
        public OptionsControlViewModel()
        {
            SaveGameControlVisibility = Visibility.Hidden;
            LoadGameControlVisibility = Visibility.Hidden;
            LeaveGameConfirmationControlVisibility = Visibility.Hidden;
            GameplayOptionsControlVisibility = Visibility.Hidden;
            InitializeCommands();
            SavesList = new();
        }
        public void HideControls()
        {
            OptionsMenuControlVisibility = Visibility.Hidden;
            GameplayOptionsControlVisibility = Visibility.Hidden;
            SaveGameControlVisibility = Visibility.Hidden;
            LoadGameControlVisibility = Visibility.Hidden;
            LeaveGameConfirmationControlVisibility = Visibility.Hidden;
            OverwriteControlVisibility = Visibility.Hidden;
            DeletingControlVisibility = Visibility.Hidden;
            LoadGameConfirmationControlVisibility = Visibility.Hidden;
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
            HideLoadingGameConfirmationControlCommand = new HideLoadingGameConfirmationControlCommand(this);
            ShowLoadingGameConfirmationControlCommand = new ShowLoadingGameConfirmationControlCommand(this);
            ExecuteTemporaryCommand = new ExecuteTemporaryCommand(this);
            GameplayOverwriteSaveGameCommand = new GameplayOverwriteSaveGameCommand(this);
            HideSavingOverwriteControlCommand = new HideSavingOverwriteControlCommand(this);
            ConfirmSaveGameDeletingCommand = new ConfirmSaveGameDeletingCommand(this);
            HideSaveDeletingControlCommand = new HideSaveDeletingControlCommand(this);
            SaveGameCommand = new RelayCommand(SaveGame);
            LoadGameCommand = new RelayCommand(LoadGame);
            SaveSettingsCommand = new RelayCommand(SaveSettings);
            OverwriteSaveGameCommand = new RelayCommand(OverwriteSaveGame);
            DeleteSaveGameCommand = new RelayCommand(DeleteSaveGame);
        }
        private void SaveSettings()
        {
            MainWindowViewModel.SaveApplicationSettingsCommand.Execute(null);
            MainWindowViewModel.ShowNotificationCommand.Execute("Settings saved");
        }
        private void SaveGame()
        {
            ArmoryViewModel.SaveGameCommand.Execute(false);
            MainWindowViewModel.ShowNotificationCommand.Execute("Game saved");
            SavesList.FillSavesCollection();
            SavesList.SelectionIndex = 0;
        }
        private void OverwriteSaveGame()
        {
            SavesList.DeleteSelectedSave();
            OverwriteControlVisibility = Visibility.Hidden;
            ArmoryViewModel.SaveGameCommand.Execute(false);
            MainWindowViewModel.ShowNotificationCommand.Execute("Game saved");
            SavesList.FillSavesCollection();
            SavesList.SelectionIndex = 0;
        }
        private void DeleteSaveGame()
        {
            SavesList.DeleteSelectedSave();
            DeletingControlVisibility = Visibility.Hidden;
        }
        private void LoadGame()
        {
            ArmoryViewModel.LoadSaveDataCommand.Execute(SavesList.Saves[SavesList.SelectionIndex].Path);
        }
    }
}
