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
                    throw new Exception($"Item with ID {ID} no exists.");
            }
        }

        public static ItemAttributes ID1()
        {
            var itemAttributes = new ItemAttributes();

            itemAttributes.Stamina = 27;
            itemAttributes.Intellect = 34;
            itemAttributes.WeaponDamageValue = 35;
            itemAttributes.Strength = 4;

            return itemAttributes;
        }
    }
}
