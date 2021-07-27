using GameEngine.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Inventory.Interfaces
{
    public interface IInventoryItemsList
    {
        int MaxItemsInInventory { get; }
        Dictionary<ItemEntity, string> ItemsInInventory { get; }
        Dictionary<string, string> GetDescription(int index);
        void AddItem(ItemEntity item);
        void RemoveItem(ItemEntity item);
    }
}
