using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Equipment
{
    public static class ItemsList
    {
        public static ItemAttributes GetAttributes(uint ID)
        {
            switch (ID)
            {
                case 1:
                    return ID1();
                default:
                    string ex = $"Item with ID {ID} no exists.";
                    throw new Exception(ex);
            }
        }

        public static ItemAttributes ID1()
        {
            var itemAttributes = new ItemAttributes();

            itemAttributes.Stamina = 25;

            return itemAttributes;
        }
    }
}
