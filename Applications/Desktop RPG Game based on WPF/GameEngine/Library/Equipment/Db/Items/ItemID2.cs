﻿using GameEngine.Equipment.Db.Items.Interfaces;

namespace GameEngine.Equipment.Db.Items
{
    public class ItemID2 : IItemCreationService
    {
        public ItemAttributes GetAttributes()
        {
            var attributes = new ItemAttributes();

            attributes.ID = 2;

            attributes.Stamina = 10;
            attributes.Strength = 10;
            attributes.Intellect = 10;
            attributes.Endurance = 10;
            attributes.Agility = 10;
            attributes.Endurance = 10;
            attributes.ArmorValue = 100;
            attributes.WeaponDamageValue = 5;

            return attributes;
        }
        public ItemModel GetModel()
        {
            int id = 2;
            string itemName = "Another Yet Item";
            var quality = ITEM_QUALITY.Poor;
            var equipmentType = EQUIPMENT_TYPE.Helmet;
            var price = new ItemCostData(100);

            return new ItemModel(id, itemName, quality, equipmentType, price);
        }
    }
}