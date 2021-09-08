using GameEngine.CombatEngine;
using GameEngine.Data;
using GameEngine.Data.Services;
using GameEngine.Player;
using GameOfFrameworks.Infrastructure.Commands.LoadGame;
using GameOfFrameworks.Models.LoadGame;
using GameOfFrameworks.Scenes.UserControls;
using GameOfFrameworks.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Input;

namespace GameOfFrameworks.ViewModels
{
    public class LoadGameViewModel : ViewModel
    {
        private List<string> _Names;
        public List<string> Names { get => _Names; set { _Names = value; OnPropertyChanged(); } }

        private PlayerEntity _CharacterEntity;
        public PlayerEntity CharacterEntity 
        { 
            get => _CharacterEntity; 
            set { _CharacterEntity = value; OnPropertyChanged(); } 
        }
        private PlayerConsumablesData _PlayerConsumables;
        public PlayerConsumablesData PlayerConsumables 
        { 
            get => _PlayerConsumables; 
            set { _PlayerConsumables = value; OnPropertyChanged(); } 
        }
        private string _SaveDateTime;
        public string SaveDateTime 
        { 
            get => _SaveDateTime; 
            set { _SaveDateTime = value; OnPropertyChanged(); } 
        }
        private PlayerSaveData _SaveData;
        public PlayerSaveData SaveData 
        { 
            get => _SaveData; 
            set { _SaveData = value; OnPropertyChanged(); } 
        }
        private int _SaveSelectionIndex;
        public int SaveSelectionIndex 
        { 
            get => _SaveSelectionIndex; 
            set { _SaveSelectionIndex = value; SelectionUpdateService.Execute(); OnPropertyChanged(); } 
        }
        public CharacterSelectionUpdateService SelectionUpdateService { get; private set; }
        public ICommand DeleteGameSaveCommand { get; set; }
        public CustomConfirmationDialogUserControl DialogUserControl { get; set; }
        public LoadGameViewModel()
        {
            SelectionUpdateService = new CharacterSelectionUpdateService(this);
            InitializeCharacterSaveNamesList();
            if (Names.Count > 0)
            {
                InitializeDefaultCharacterSaveData();
            }

            InitializeCommands();
        }
        public void InitializeCharacterSaveNamesList()
        {
            Names = new List<string>();

            var specialFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var directoryInfo = new DirectoryInfo(specialFolderPath + "\\Games\\Game of Frameworks\\Saves\\");

            foreach (var item in directoryInfo.EnumerateDirectories())
                Names.Add(item.Name);
        }
        private void InitializeDefaultCharacterSaveData()
        {
            var playerEntityConstructor = new PlayerEntityConstructor();
            var saveDataJsonDeserializer = new SaveDataJsonDeserializer();
            SaveData = saveDataJsonDeserializer.Deserialize(Names[0]);
            SaveDateTime = SaveData.Date;
            PlayerConsumables = new PlayerConsumablesData(SaveData.Money);
            var playerModelData = new PlayerModelData(SaveData.Specialization, SaveData.Gender, SaveData.Name, SaveData.Level, SaveData.Money);
            CharacterEntity = playerEntityConstructor.CreatePlayer(playerModelData, SaveData.PlayerAttributes);
        }
        private void InitializeCommands()
        {
            DeleteGameSaveCommand = new DeleteGameSaveCommand(this);
        }
    }
}
