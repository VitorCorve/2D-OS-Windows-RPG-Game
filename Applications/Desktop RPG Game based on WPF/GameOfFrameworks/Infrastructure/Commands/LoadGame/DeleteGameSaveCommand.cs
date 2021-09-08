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
            var specialFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var characterDirectory = new DirectoryInfo(specialFolderPath + $"\\Games\\Game of Frameworks\\Saves\\{ViewModel.SaveData.Name}\\");

            ViewModel.SelectionUpdateService.ExecuteNext();
            ViewModel.InitializeCharacterSaveNamesList();
            ViewModel.OnPropertyChanged();

/*            foreach (FileInfo file in characterDirectory.GetFiles())
                file.Delete();
            Directory.Delete(characterDirectory.FullName);*/

        }
    }
}
