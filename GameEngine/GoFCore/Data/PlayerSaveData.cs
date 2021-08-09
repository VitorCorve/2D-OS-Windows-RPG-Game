using GameEngine.Data.Interfaces;
using GameEngine.Equipment;
using GameEngine.Inventory;
using GameEngine.Player;
using System.Collections.Generic;
using GameEngine.Player.ModelConditions;
using GameEngine.Equipment.Resource;
using Newtonsoft.Json;

namespace GameEngine.Data
{
    public class PlayerSaveData : IPlayerSaveData
    {
        public WearedEquipment Equipment { get; set; }
        public PlayerInventoryItemsList Inventory { get; set; }
        public PlayerSkillList Skills { get; set; }
        public int AvailableSkillPoints { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public GENDER Gender { get; set; }
        public int Money { get; set; }
        public PlayerBiography Bio { get; set;}
        public PlayerAvatar Avatar_ID { get; set; }
    }
}
