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
            var itemConstructor = new ItemAttributesConstructor();

            for (int i = 0; i < id.Length; i++)
            {
                ItemsList.Add(itemConstructor.CreateItem(id[i]));
            }

        }
    }
}
