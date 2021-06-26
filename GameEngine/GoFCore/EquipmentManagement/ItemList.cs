using GameEngine.EquipmentManagement.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.EquipmentManagement
{
    public class ItemList
    {
        public List<ItemEntity> Items = new List<ItemEntity> { };

        public void Add(ItemEntity item)
        {
            Items.Add(item);
        }
    }
}
