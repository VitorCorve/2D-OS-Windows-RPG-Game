using System;
using GameEngine.Equipment.Db.Models;
using GameEngine.Equipment.Db.Services;

namespace GameEngine.Equipment
{
    public class ItemModelConstructor
    {
        public ItemModel CreateItem(DbConnectionService database, int id)
        {
            var itemModelDB = database.GetModel(id);

            var itemName = itemModelDB.ItemName;
            var itemQuality = (ITEM_QUALITY)Enum.Parse(typeof(ITEM_QUALITY), itemModelDB.Quality);
            var wearType = (EQUIPMENT_TYPE)Enum.Parse(typeof(EQUIPMENT_TYPE), itemModelDB.WearType);
            var price = new ItemCostData(itemModelDB.Price);

            var itemModel = new ItemModel(itemModelDB.ID, itemName, itemQuality, wearType, price);

            return itemModel;
        }
    }
}
