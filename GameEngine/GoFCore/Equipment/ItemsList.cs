using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Equipment
{
    public static class ItemsList
    {
        public static ItemAttributes GetAttributes(int ID)
        {
            switch (ID)
            {
                case 0:
                    return ID0();
                case 1:
                    return ID1();
                case 2:
                    return ID2();
                default:
                    throw new Exception($"Item with ID {ID} no exists.");
            }
        }
        public static ItemAttributes ID0()
        {
            var itemAttributes = new ItemAttributes();

            return itemAttributes;
        }
        public static ItemAttributes ID1()
        {
            var itemAttributes = new ItemAttributes();

            itemAttributes.Stamina = 27;
            itemAttributes.Agility = 32;
            itemAttributes.Intellect = 34;
            itemAttributes.WeaponDamageValue = 25;
            itemAttributes.Strength = 4;

            return itemAttributes;
        }

        public static ItemAttributes ID2()
        {
            var itemAttributes = new ItemAttributes();

            itemAttributes.Stamina = 30;
            itemAttributes.Intellect = 4;
            itemAttributes.WeaponDamageValue = 3;
            itemAttributes.Strength = 5;
            itemAttributes.ArmorValue = 40;

            return itemAttributes;
        }
    }
}
