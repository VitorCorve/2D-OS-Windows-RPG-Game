using GameEngine.Equipment;
using GameEngine.Inventory;
using GameEngine.Player;
using System.Collections.Generic;

namespace GameEngine.LootMaster.Interfaces
{
    public interface ILootMaster
    {
        PlayerInventoryItemsList Inventory { get; }
        PlayerConsumablesData Consumables { get; }
        List<ItemEntity> ProbableLootList { get; }
        List<ItemEntity> Loot { get; }
        int MoneyReward { get; }
        void ThrowItems();
        void PickUpItem(int index);
        void PickUpAllItems();
        void PrepareLoot();
    }
}
