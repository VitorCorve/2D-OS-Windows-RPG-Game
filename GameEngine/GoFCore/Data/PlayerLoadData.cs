using GameEngine.Abstract;
using GameEngine.Data.Interfaces;
using GameEngine.Equipment;
using GameEngine.Inventory;
using GameEngine.Player;
using GameEngine.Player.Abstract;
using GameEngine.Player.Specializatons.Mage;
using GameEngine.Player.Specializatons.Rogue;
using GameEngine.Player.Specializatons.Warrior;
using GameEngine.Specializatons;
using System.Collections.Generic;

namespace GameEngine.Data
{
    public class PlayerLoadData : IPlayerLoadData
    {
        public WearedEquipment Equipment { get; set; }
        public PlayerInventoryItemsList Inventory { get; set; }
        public PlayerSkillList Skills { get; set; }
        public List<ItemAttributes> ItemsList { get; set; }
        public PlayerModelData PlayerModel { get; set; }
        public PlayerSpecialization Specialization { get; set; }
        public IEntityAttributes SpecializationAttributes { get; set; }
        public PlayerLoadData(PlayerSaveData playerSaveData)
        {
            Equipment = playerSaveData.Equipment;
            Inventory = playerSaveData.Inventory;
            Skills = playerSaveData.Skills;
            ItemsList = playerSaveData.ItemsList;

            switch (playerSaveData.Specialization)
            {
                case "mage":
                    Specialization = new Mage();
                    SpecializationAttributes = new EntityModel_Mage();
                    break;
                case "rogue":
                    Specialization = new Rogue();
                    SpecializationAttributes = new EntityModel_Rogue();
                    break;
                default:
                    Specialization = new Warrior();
                    SpecializationAttributes = new EntityModel_Warrior();
                    break;
            }
            PlayerModel = new PlayerModelData(Specialization, playerSaveData.Gender, playerSaveData.Name, playerSaveData.Level, playerSaveData.Money);

        }
    }
}
