using GameEngine.Equipment.Db.Items;

namespace GameEngine.Equipment.Db
{
    public class ItemAttributesCreator
    {
        public ItemAttributes CreateAttributesByID(int ID)
        {
            switch (ID)
            {
                case 1:
                    return new ItemID1().GetAttributes();
                case 2:
                    return new ItemID2().GetAttributes();
                default:
                    return new ItemID0().GetAttributes();
            }
        }
    }
}
