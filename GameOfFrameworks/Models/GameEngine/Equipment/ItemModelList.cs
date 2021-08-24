using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Equipment
{
    public static class ItemModelList
    {
        public static ItemModel GetModel(int ID)
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
        public static ItemModel ID0()
        {
            var itemCostData = new ItemCostData(1000);
            var itemAttributes = new ItemModel
            (
                0,
                "Bad helmet",
                ITEM_QUALITY.Poor,
                EQUIPMENT_TYPE.Helmet,
                itemCostData
            );

            return itemAttributes;
        }
        public static ItemModel ID1()
        {
            var itemCostData = new ItemCostData(1000);
            var itemAttributes = new ItemModel
            (
                1,
                "Not bad helmet",
                ITEM_QUALITY.Good,
                EQUIPMENT_TYPE.Helmet,
                itemCostData
            );

            return itemAttributes;
        }

        public static ItemModel ID2()
        {
            var itemCostData = new ItemCostData(1000);
            var itemAttributes = new ItemModel
            (
                2,
                "Good helmet",
                ITEM_QUALITY.Good,
                EQUIPMENT_TYPE.Helmet,
                itemCostData
            );

            return itemAttributes;
        }
    }
}
