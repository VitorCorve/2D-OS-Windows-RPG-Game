using GameEngine.Equipment.Db.Items;

namespace GameEngine.Equipment.Db
{
    public class ItemModelCreator
    {
        public ItemModel CreateModelByID(int ID)
        {
            switch (ID)
            {
                case 1:
                    return new ItemID1().GetModel();
                case 2:
                    return new ItemID2().GetModel();
                default:
                    return new ItemID0().GetModel();
            }
        }
    }
}
