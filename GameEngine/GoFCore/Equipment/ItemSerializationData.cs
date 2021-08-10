using System.Collections.Generic;

namespace GameEngine.Equipment
{
    public class ItemSerializationData
    {
        public int[] ID { get; set; }
        public int[] ItemDurability { get; set; }
        public void PrepareToSerialize(List<ItemEntity> itemsList)
        {
            ID = new int[itemsList.Count];
            ItemDurability = new int[itemsList.Count];
            int count = 0;

            foreach (var item in itemsList)
            {
                ID[count] = item.Model.ID;
                ItemDurability[count] = item.ItemDurability.Value;
                count++;
            }
        }
        public List<ItemEntity> ConvertToItemsEntityList()
        {
            var itemsList = new List<ItemEntity> { };

            for (int i = 0; i < ID.Length; i++)
            {
                itemsList.Add(new ItemEntity((ID[i]), ItemDurability[i]));
            }
            return itemsList;
        }
    }
}
