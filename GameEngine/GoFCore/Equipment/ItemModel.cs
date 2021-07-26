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
        public readonly ItemCostData Cost;
        public ItemModel(int id, string itemName, ITEM_QUALITY quality, EQUIPMENT_TYPE wearType, ItemCostData cost)
        {
            ID = id;
            ItemName = itemName;
            Quality = quality;
            WearType = wearType;
            Cost = cost;
        }
    }
}
