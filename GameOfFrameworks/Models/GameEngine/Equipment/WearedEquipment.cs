using GameEngine.Equipment.Interfaces;
using GameEngine.Equipment.Resource;
using System.Collections.Generic;

namespace GameEngine.Equipment
{
    public class WearedEquipment : IWearedEquipment
    {
        public List<ItemEntity> ItemsList { get; private set; } = new();
        public void WearGear(ItemEntity item)
        {
            ItemsList.Add(item);
        }
        public void TakeOffGear(ItemEntity item)
        {
            foreach (var itemInItemList in ItemsList)
            {
                if (itemInItemList.Model.ID == item.Model.ID)
                    ItemsList.Remove(itemInItemList);
            }
        }
        public WearedEquipment(params int[] id)
        {
            for (int i = 0; i < id.Length; i++)
            {
                var itemEntity = new ItemEntity(id[i]);
                ItemsList.Add(itemEntity);
            }
        }
        public WearedEquipment(List<ItemEntity> itemsList)
        {
            foreach (var item in itemsList)
            {
                ItemsList.Add(item);
            }
        }
        public WearedEquipment()
        {

        }
    }
}
