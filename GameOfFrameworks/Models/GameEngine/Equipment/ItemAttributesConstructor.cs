using GameEngine.Equipment.Db.Services;

namespace GameEngine.Equipment
{
    public class ItemAttributesConstructor
    {
        public ItemAttributes CreateItem(DbConnectionService database, int id)
        {
            return database.GetAttributes(id);
        }
    }
}
