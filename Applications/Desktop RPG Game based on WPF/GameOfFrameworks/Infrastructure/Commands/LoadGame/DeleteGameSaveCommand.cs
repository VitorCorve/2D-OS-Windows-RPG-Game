using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels;
using System.IO;

namespace GameOfFrameworks.Infrastructure.Commands.LoadGame
{
    public class DeleteGameSaveCommand : Command
    {
        public LoadGameViewModel ViewModel { get; private set; }
        public DeleteGameSaveCommand(LoadGameViewModel loadGameViewModel) => ViewModel = loadGameViewModel;
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            var filePath = ViewModel.Model.SelectedGameSavePath;

            ViewModel.Model.CleanGameSavesList();
            ViewModel.Model.SelectionUpdateService.MoveToNextSaveSelectionIndex();

            File.Delete(filePath);

            if (ViewModel.Model.GameSaves.Count == 0) ViewModel.Model.CleanSaveViewData();
        }
    }
}
