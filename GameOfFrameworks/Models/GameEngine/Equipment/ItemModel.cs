using GameEngine.Equipment.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Equipment
{
    public class ItemModel
    {
        public readonly int ID;
        public readonly string ItemName;
        public readonly ITEM_QUALITY Quality;
        public readonly EQUIPMENT_TYPE WearType;
        public readonly ItemCostData Price;
        public ItemModel(int id, string itemName, ITEM_QUALITY quality, EQUIPMENT_TYPE wearType, ItemCostData price)
        {
            ID = id;
            ItemName = itemName;
            Quality = quality;
            WearType = wearType;
            Price = price;
        }
        public ItemModel(ItemModelDB itemModel)
        {
            ID = itemModel.ID;
            ItemName = itemModel.ItemName;
            Quality = (ITEM_QUALITY)Enum.Parse(typeof(ITEM_QUALITY), itemModel.Quality);
            WearType = (EQUIPMENT_TYPE)Enum.Parse(typeof(EQUIPMENT_TYPE), itemModel.WearType);
            Price = new ItemCostData(itemModel.Price);
        }
    }
}
