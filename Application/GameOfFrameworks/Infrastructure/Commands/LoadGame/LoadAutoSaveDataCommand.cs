using GameEngine.CombatEngine;
using GameEngine.Data;
using GameEngine.Data.Services;
using GameEngine.Equipment;
using GameEngine.EquipmentManagement;
using GameEngine.Inventory;
using GameEngine.Locations.Services;
using GameEngine.Player;
using GameEngine.Player.Abstract;
using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.Armory.AttributesControl;
using GameOfFrameworks.Models.Services;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.Models.UISkillsCollection.Player.Services;
using System;


namespace GameOfFrameworks.Infrastructure.Commands.LoadGame
{
    public class LoadAutoSaveDataCommand : Command
    {
        private PlayerSaveData SaveData = new();
        private readonly SaveDataJsonDeserializer DataDeserializer = new();
        private readonly string SavePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Games\\Game of Frameworks\\Saves\\Autosave.json";
        private readonly LocationBuilder LocationBuildingService = new();
        private readonly PlayerEntityConstructor EntityConstructor = new();
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            if (ArmoryTemporaryData.SaveData is null) DeserializeData();
            else SaveData = ArmoryTemporaryData.SaveData;

            InitializeArmoryTemporaryData();
            InitalizeUI();
        }
        private void DeserializeData() => SaveData = DataDeserializer.Deserialize(SavePath);
        private void InitializeArmoryTemporaryData()
        {
            ArmoryTemporaryData.CurrentLocation = LocationBuildingService.Build(SaveData.CurrentTown);
            ArmoryTemporaryData.PlayerModel = new PlayerModelData(SaveData);
            ArmoryTemporaryData.CharacterEntity = BuildPlayerEntitiy(ArmoryTemporaryData.PlayerModel, SaveData.PlayerAttributes, BuildEquipmentValue(ArmoryTemporaryData.PlayerEquipment ?? null));
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
        private PlayerEntity BuildPlayerEntitiy(PlayerModelData playerModel, IEntityAttributes playerAttributes, IEntityAttributes equipmentValue = null)
        {
            var playerEntity = EntityConstructor.CreatePlayer(playerModel, playerAttributes, equipmentValue ?? null);
            playerEntity.HealthPoints.Value = SaveData.PlayerHealthValue;
            playerEntity.ManaPoints.Value = SaveData.PlayerManaValue;
            playerEntity.EnergyPoints.Value = SaveData.PlayerEnergyValue;

            return playerEntity;
        }
        private EquipmentValue BuildEquipmentValue(WearedEquipment wearedEquipment) => new EquipmentValue(wearedEquipment);
    }
}
