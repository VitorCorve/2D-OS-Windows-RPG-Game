using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Input;
using System.Linq;
using GameOfFrameworks.ViewModels;
using GameOfFrameworks.Models.Temporary;
using GameEngine.Locations.Services;
using GameEngine.CombatEngine;
using GameEngine.Player;
using GameEngine.Data;
using GameEngine.Equipment;
using GameEngine.Inventory;
using GameOfFrameworks.Models.UISkillsCollection.Player.Services;
using GameOfFrameworks.Models.Armory.AttributesControl;
using GameOfFrameworks.Models.Services;
using GameEngine.Player.Abstract;
using GameEngine.EquipmentManagement;
using GameEngine.Data.Services;

namespace GameOfFrameworks.Infrastructure.Commands.MainMenu
{
    public class ContinueGameCommand : ICommand
    {
        private PlayerSaveData SaveData = new();
        private readonly SaveDataJsonDeserializer DataDeserializer = new();
        public string SavePath { get; private set; }
        private readonly LocationBuilder LocationBuildingService = new();
        private readonly PlayerEntityConstructor EntityConstructor = new();
        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            Dictionary<DateTime, string> savesPathList = new Dictionary<DateTime, string>();

            DirectoryInfo dirInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Games\\Game of Frameworks\\Saves\\");

            foreach (var item in dirInfo.EnumerateFiles())
            {
                savesPathList.Add(item.CreationTime, item.FullName);
            }
            if (savesPathList is null && savesPathList.Count == 0) return;

            var sortedSavesPath = from i in savesPathList
                                  orderby i.Key descending
                                  select i.Value;

            SavePath = sortedSavesPath.First();
            DeserializeData();
            InitializeArmoryTemporaryData();
            InitalizeUI();
            ArmoryTemporaryData.Instance.NavigationService.Navigate(new GameOfFrameworks.Scenes.Armory());
            MainWindowViewModel.ShowNotificationCommand.Execute("Loaded...");
        }
        private void DeserializeData() => SaveData = DataDeserializer.Deserialize(SavePath);
        private void InitializeArmoryTemporaryData()
        {
            ArmoryTemporaryData.CurrentLocation = LocationBuildingService.Build(SaveData.CurrentTown);
            ArmoryTemporaryData.PlayerModel = new PlayerModelData(SaveData);

            if (ArmoryTemporaryData.PlayerEquipment is null)
                ArmoryTemporaryData.CharacterEntity = BuildPlayerEntity(ArmoryTemporaryData.PlayerModel, SaveData.PlayerAttributes);
            else
                ArmoryTemporaryData.CharacterEntity = BuildPlayerEntity(ArmoryTemporaryData.PlayerModel, SaveData.PlayerAttributes, BuildEquipmentValue(ArmoryTemporaryData.PlayerEquipment ?? null));
            
            ArmoryTemporaryData.SaveData = SaveData;
            ArmoryTemporaryData.PlayerAttributes = SaveData.PlayerAttributes;
            ArmoryTemporaryData.PlayerEquipment = new WearedEquipment(SaveData.ItemsOnCharacter.ConvertToWearedEquipmentItemsList());
            ArmoryTemporaryData.PlayerInventory = new PlayerInventoryItemsList(SaveData.ItemsInInventory.ConvertToInventoryItemsList());
            ArmoryTemporaryData.PlayerSkills = SaveData.PlayerSkills;
        }
        private void InitalizeUI()
        {
            if (SaveData.UISkillPlacementData is null)
            {
                var skillToSkillViewConverter = new SkillToSkillViewConverter(SaveData.Specialization);
                ArmoryTemporaryData.SkillsShortcuts = new ShortcutsListModel();
                ArmoryTemporaryData.SkillsShortcuts.Initialize(skillToSkillViewConverter.ConvertRangeToObservableCollection(ArmoryTemporaryData.PlayerSkills.Skills));
            }
            else ArmoryTemporaryData.SkillsShortcuts = ShortcutsConverter.ConvertToShortcuts(SaveData.UISkillPlacementData, SaveData.Specialization);
        }
        private PlayerEntity BuildPlayerEntity(PlayerModelData playerModel, IEntityAttributes playerAttributes, IEntityAttributes equipmentValue = null)
        {
            var playerEntity = EntityConstructor.CreatePlayer(playerModel, playerAttributes, equipmentValue ?? null);
            playerEntity.HealthPoints.Value = SaveData.PlayerHealthValue;
            playerEntity.ManaPoints.Value = SaveData.PlayerManaValue;
            playerEntity.EnergyPoints.Value = SaveData.PlayerEnergyValue;

            return playerEntity;
        }
        private PlayerEntity BuildPlayerEntity(PlayerModelData playerModel, IEntityAttributes playerAttributes)
        {
            var playerEntity = EntityConstructor.CreatePlayer(playerModel, playerAttributes);
            playerEntity.HealthPoints.Value = SaveData.PlayerHealthValue;
            playerEntity.ManaPoints.Value = SaveData.PlayerManaValue;
            playerEntity.EnergyPoints.Value = SaveData.PlayerEnergyValue;

            return playerEntity;
        }
        private EquipmentValue BuildEquipmentValue(WearedEquipment wearedEquipment) => new EquipmentValue(wearedEquipment);
    }
}
