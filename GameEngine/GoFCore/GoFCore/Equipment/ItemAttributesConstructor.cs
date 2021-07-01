using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Equipment
{
    public class ItemAttributesConstructor
    {
        public ItemAttributes CreateItem(uint ID)
        {
            var item = ItemsList.GetAttributes(ID);
            return item;
        }
    }
}
