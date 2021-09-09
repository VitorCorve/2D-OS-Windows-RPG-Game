using GameOfFrameworks.Infrastructure.Commands.LoadGame;
using GameOfFrameworks.Models.LoadGame;
using GameOfFrameworks.Scenes.UserControls;
using GameOfFrameworks.ViewModels.Base;
using System.Windows.Input;

namespace GameOfFrameworks.ViewModels
{
    public class LoadGameViewModel : ViewModel
    {
        private LoadGameModel _Model;
        public LoadGameModel Model
        {
            get => _Model;
            set => Set(ref _Model, value);
        }
        public ICommand DeleteGameSaveCommand { get; set; }
        public CustomConfirmationDialogUserControl DialogUserControl { get; set; }
        public LoadGameViewModel()
        {
            Model = new LoadGameModel();
            Model.SetupCharacterGameSavesList();
            Model.SetDefaultSaveData();
            InitializeCommands();
        }
        private void InitializeCommands() => DeleteGameSaveCommand = new DeleteGameSaveCommand(this);
    }
}
