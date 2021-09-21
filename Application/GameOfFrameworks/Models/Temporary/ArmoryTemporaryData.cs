using GameEngine.CombatEngine;
using GameEngine.Data;
using GameEngine.Equipment;
using GameEngine.Inventory;
using GameEngine.Player;

namespace GameOfFrameworks.Models.Temporary
{
    public static class ArmoryTemporaryData
    {
        public static PlayerEntity CharacterEntity { get; set; }
        public static PlayerModelData PlayerModel { get; set; }
        public static PlayerSaveData SaveData { get; set; }
        public static PlayerInventoryItemsList PlayerInventory { get; set; }
        public static WearedEquipment PlayerEquipment { get; set; }
    }
}
