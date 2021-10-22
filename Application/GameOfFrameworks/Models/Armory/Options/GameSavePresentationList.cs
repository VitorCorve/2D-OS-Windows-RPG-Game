using GameEngine.Data.Services;
using System;
using System.Linq;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;

namespace GameOfFrameworks.Models.Armory.Options
{
    public class GameSavePresentationList : INotifyPropertyChanged
    {
        private readonly DirectoryInfo Directory;
        private readonly SaveDataJsonDeserializer Deserializer;
        private ObservableCollection<SaveGamePresentationModel> _Saves;
        private SaveDataPresentationModel _SaveModel;
        private int _SelectionIndex;
        public ObservableCollection<SaveGamePresentationModel> Saves { get => _Saves; set { _Saves = value; OnPropertyChanged(); } }

        public event PropertyChangedEventHandler PropertyChanged;
        public SaveDataPresentationModel SaveModel { get => _SaveModel; set { _SaveModel = value; OnPropertyChanged(); } }
        public int SelectionIndex { get => _SelectionIndex; set { _SelectionIndex = value; BuildModel(value); } }
        public GameSavePresentationList()
        {
            Deserializer = new();
            Directory = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Games\\Game of Frameworks\\Saves\\");
            FillSavesCollection();
            BuildModel(SelectionIndex);
        }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        public void FillSavesCollection()
        {
            Saves = new();

            foreach (var item in Directory.EnumerateFiles())
            {
                SaveGamePresentationModel saveGamePresentationModel = new SaveGamePresentationModel
                {
                    Path = item.FullName
                };
                saveGamePresentationModel.SaveData = Deserializer.Deserialize(saveGamePresentationModel.Path);
                saveGamePresentationModel.Name = saveGamePresentationModel.SaveData.Name;

                Saves.Add(saveGamePresentationModel);
            }
            SortSaves();
        }
        public void DeleteSelectedSave()
        {
            string fileToRemovePath = Saves[SelectionIndex].Path;
            Saves.RemoveAt(SelectionIndex);
            File.Delete(fileToRemovePath);
            SortSaves();
        }
        public void SortSaves()
        {
            var orderSavesByDate = from i in Saves
                                   orderby i.SaveData.Date descending
                                   select i;

            var saves = new ObservableCollection<SaveGamePresentationModel>();

            foreach (var item in orderSavesByDate)
                saves.Add(item);

            Saves = saves;
        }
        private void BuildModel(int index)
        {
            index = ValidateIndex(index);
            SaveModel = new();
            SaveModel.Show(Saves[index].SaveData);
        }
        private int ValidateIndex(int index)
        {
            if (index < 0) return 0;
            else return index;
        }
    }
}
