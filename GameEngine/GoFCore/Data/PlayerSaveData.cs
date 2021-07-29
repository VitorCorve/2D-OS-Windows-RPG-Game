using GameEngine.Data.Interfaces;
using GameEngine.Abstract;
using GameEngine.Equipment;
using GameEngine.Inventory;
using GameEngine.Player;
using GameEngine.Player.Abstract;
using System.Collections.Generic;

namespace GameEngine.Data
{
    public class PlayerSaveData : IPlayerSaveData
    {
        public WearedEquipment Equipment { get; set; }
        public PlayerInventoryItemsList Inventory { get; set; }
        public PlayerSkillList Skills { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public GENDER Gender { get; set; }
        public int Money { get; set; }
        public List<ItemAttributes> ItemsList { get; set; }

    }
}
