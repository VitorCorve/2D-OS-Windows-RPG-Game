using GameEngine.Equipment.Interfaces;
using GameEngine.Equipment.Resource;
using System.Collections.Generic;

namespace GameEngine.Equipment
{
    public class WearedEquipment : IWearedEquipment
    {
        public Dictionary<ItemAttributes, Durability> ItemsList { get; private set; } = new();
        public void WearGear(ItemEntity item)
        {
            ItemsList.Add(item.Attributes, item.ItemDurability);
        }
        public void TakeOffGear(ItemEntity item)
        {
            foreach (var itemInItemList in ItemsList)
            {
                if (itemInItemList.Key.ID == item.Model.ID)
                {
                    ItemsList.Remove(itemInItemList.Key);
                }
            }
        }
        public WearedEquipment(params int[] id)
        {
            for (int i = 0; i < id.Length; i++)
            {
                var itemEntity = new ItemEntity(id[i]);
                ItemsList.Add(itemEntity.Attributes, itemEntity.ItemDurability);
            }
        }
        public WearedEquipment(Dictionary<ItemAttributes, Durability> itemsList)
        {
            ItemsList = itemsList;
        }
        public WearedEquipment(List<ItemEntity> itemsList)
        {
            foreach (var item in itemsList)
            {
                ItemsList.Add(item.Attributes, item.ItemDurability);
            }
        }
        public WearedEquipment()
        {

        }
    }
}
