using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Equipment
{
    public class ItemModelConstructor
    {
        public ItemModel CreateItem(int ID)
        {
            var item = ItemModelList.GetModel(ID);
            return item;
        }
    }
}
