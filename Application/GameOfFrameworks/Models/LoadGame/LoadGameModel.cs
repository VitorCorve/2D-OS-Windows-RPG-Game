using GameEngine.CombatEngine;
using GameEngine.Data;
using GameEngine.Data.Services;
using GameEngine.Equipment;
using GameEngine.EquipmentManagement;
using GameEngine.Player;
using GameOfFrameworks.ViewModels.Base;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;

namespace GameOfFrameworks.Models.LoadGame
{
    public class LoadGameModel : ViewModel
    {
        private ObservableCollection<GameSaveModel> _GameSaves;
        private PlayerEntity _CharacterEntity;
        private PlayerConsumablesData _PlayerConsumables;
        private string _SaveDateTime;
        private PlayerSaveData _SaveData;
        private int _SaveSelectionIndex;
        private string _CharacterGender;
        private string _CharacterSpecialization;
        private string _SelectedGameSavePath;
        public ObservableCollection<GameSaveModel> GameSaves { get => _GameSaves; set { _GameSaves = value; OnPropertyChanged(); } }
        public PlayerEntity CharacterEntity {get => _CharacterEntity;set => Set(ref _CharacterEntity, value); }
        public PlayerConsumablesData PlayerConsumables { get => _PlayerConsumables;set => Set(ref _PlayerConsumables, value);}
        public string SaveDateTime { get => _SaveDateTime; set => Set(ref _SaveDateTime, value); }
        public PlayerSaveData SaveData { get => _SaveData; set => Set(ref _SaveData, value); }
        public int SaveSelectionIndex
        {
            get => _SaveSelectionIndex;
            set 
            { 
                Set (ref _SaveSelectionIndex, value); 
                SelectionUpdateService.Execute(); 
            }
        }
        public string CharacterGender { get => _CharacterGender; set => Set(ref _CharacterGender, value); }
        public string CharacterSpecialization { get => _CharacterSpecialization;  set { _CharacterSpecialization = value; OnPropertyChanged(); } }
        public string SelectedGameSavePath { get => _SelectedGameSavePath; set { _SelectedGameSavePath = value; OnPropertyChanged(); } }
        public CharacterSelectionUpdateService SelectionUpdateService { get; private set; }
        private readonly PlayerEntityConstructor EntityConstructor = new();
        private readonly SaveDataJsonDeserializer DataDeserializer = new();
        public LoadGameModel() => SelectionUpdateService = new CharacterSelectionUpdateService(this);
        public void CleanSaveViewData()
        {
            SaveData = new PlayerSaveData();
            SaveDateTime = "";
            CharacterEntity = new PlayerEntity();
            CharacterSpecialization = "";
            PlayerConsumables = null;
            CharacterGender = "";
        }
        public void SetDefaultSaveData()
        {
            if (GameSaves.Count == 0) return;

            SaveData = DataDeserializer.Deserialize(GameSaves[0].Path);
            SelectedGameSavePath = GameSaves[0].Path;
            SaveDateTime = SaveData.Date;
            PlayerConsumables = new PlayerConsumablesData(SaveData.Money);
            var playerModelData = new PlayerModelData(SaveData.Specialization, SaveData.Gender, SaveData.Name, SaveData.Level, SaveData.Money);

            playerModelData.CurrentTown = GameEngine.Locations.TOWN.Chartringfall;

            CharacterEntity = EntityConstructor.CreatePlayer(playerModelData, SaveData.PlayerAttributes, GetEquipmentValue(SaveData));
            CharacterSpecialization = "Specialization: " + SaveData.Specialization.ToString();
            CharacterGender = "Gender: " + SaveData.Gender.ToString();
        }
        public void SetupCharacterGameSavesList()
        {
            GameSaves = new ObservableCollection<GameSaveModel>();
            var specialFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var directoryInfo = new DirectoryInfo(specialFolderPath + "\\Games\\Game of Frameworks\\Saves\\");

            foreach (var item in directoryInfo.EnumerateFiles())
            {
                var gameSave = new GameSaveModel();
                var playerSavedata = DataDeserializer.Deserialize(item.FullName);

                if (playerSavedata.IsAutoSave) gameSave.Name = "Autosave";
                else gameSave.Name = playerSavedata.Name;
                gameSave.Path = item.FullName;
                gameSave.Date = playerSavedata.Date;
                GameSaves.Add(gameSave);
            }
            SortSaves();
        }
        public void CleanGameSavesList() => GameSaves.RemoveAt(SaveSelectionIndex);
        public EquipmentValue GetEquipmentValue(PlayerSaveData playerSaveData)
        {
            if (playerSaveData.ItemsOnCharacter is null) return null;
            else return new EquipmentValue(new WearedEquipment(playerSaveData.ItemsOnCharacter.ConvertToWearedEquipmentItemsList()));
        }
        private void SortSaves()
        {
            var orderSavesByDate = from i in GameSaves
                                   orderby i.Date descending
                                   select i;

            var saves = new ObservableCollection<GameSaveModel>();

            foreach (var item in orderSavesByDate)
                saves.Add(item);

            GameSaves = saves;
        }
    }
}
