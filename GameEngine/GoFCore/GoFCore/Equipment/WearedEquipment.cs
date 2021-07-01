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
        public WearedEquipment(params uint[] id)
        {
            var itemConstructor = new ItemAttributesConstructor();

            for (uint i = 1; i <= id.Length; i++)
            {
                ItemsList.Add(itemConstructor.CreateItem(i));
            }

        }
    }
}
