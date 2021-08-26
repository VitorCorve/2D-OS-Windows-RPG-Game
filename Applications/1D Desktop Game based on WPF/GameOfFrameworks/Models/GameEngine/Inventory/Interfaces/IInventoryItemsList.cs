using GameEngine.Equipment;
using System.Collections.Generic;

namespace GameEngine.Inventory.Interfaces
{
    public interface IInventoryItemsList
    {
        int MaxItemsInInventory { get; }
        List<ItemEntity> ItemsInInventory { get; }
        Dictionary<string, string> GetDescription(int index);
        void AddItem(ItemEntity item);
        void RemoveItem(ItemEntity item);
    }
}
