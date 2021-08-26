using GameEngine.Equipment.Db.Items.Interfaces;
using GameEngine.Equipment.Resource;

namespace GameEngine.Equipment.Db.Items
{
    public class ItemID1 : IItemCreationService
    {
        public ItemAttributes GetAttributes()
        {
            var attributes = new ItemAttributes();

            attributes.ID = 1;

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
            int id = 1;
            string itemName = "Another Item";
            var quality = ITEM_QUALITY.Poor;
            var equipmentType = EQUIPMENT_TYPE.MainWeapon;
            var price = new ItemCostData(100);

            return new ItemModel(id, itemName, quality, equipmentType, price);
        }
    }
}
