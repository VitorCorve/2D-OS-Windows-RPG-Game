using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Equipment
{
    public class ItemEntity
    {
        public ItemAttributes Attributes { get; private set; }
        public ItemModel Model { get; private set; }
        public ItemEntity(int id)
        {
            var itemAttributesConstructor = new ItemAttributesConstructor();
            var itemModelConstructor = new ItemModelConstructor();

            Attributes = itemAttributesConstructor.CreateItem(id);
            Model = itemModelConstructor.CreateItem(id);
        }
    }
}
