using GameEngine.CombatEngine;
using GameEngine.Data;
using GameEngine.Equipment;
using GameEngine.Inventory;
using GameEngine.Player;
using GameEngine.Player.Abstract;
using GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces;
using System.Collections.ObjectModel;

namespace GameOfFrameworks.Models.Temporary
{
    public static class ArmoryTemporaryData
    {
        public static PlayerEntity CharacterEntity { get; set; }
        public static PlayerModelData PlayerModel { get; set; }
        public static PlayerSaveData SaveData { get; set; }
        public static PlayerInventoryItemsList PlayerInventory { get; set; }
        public static WearedEquipment PlayerEquipment { get; set; }
        public static PlayerSkillList PlayerSkills { get; set; }
        public static IEntityAttributes PlayerAttributes { get; set; }
        public static ObservableCollection<ISkillView> AvailableSkills { get; set; }
        public static bool IsPlayerEntityChanged { get; set; }
        public static bool IsPlayerAttributesUpdated { get; set; }
        public static bool IsPlayerSkillsUpdated { get; set; }
    }
}
