using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels;
using System;
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
            foreach (var item in ViewModel.Model.GameSaves)
            {
                if (item.Name == ViewModel.Model.SaveData.Name)
                    File.Delete(item.Path);
            }

            ViewModel.Model.SetupCharacterGameSavesList();
            if (ViewModel.Model.GameSaves.Count == 0) ViewModel.Model.CleanSaveViewData();
        }
    }
}
