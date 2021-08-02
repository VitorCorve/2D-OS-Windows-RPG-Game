using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Equipment
{
    public class WearedEquipment
    {
        public List<ItemAttributes> ItemsList = new List<ItemAttributes> { };
        public WearedEquipment(params int[] id)
        {
            for (int i = 0; i < id.Length; i++)
            {
                var itemEntity = new ItemEntity(id[i]);
                ItemsList.Add(itemEntity.Attributes);
            }
        }
    }
}
