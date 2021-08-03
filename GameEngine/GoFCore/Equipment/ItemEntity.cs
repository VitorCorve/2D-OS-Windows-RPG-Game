using GameEngine.Equipment.Db.Services;

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
            var dbConnection = new DbConnectionService();

            Attributes = itemAttributesConstructor.CreateItem(dbConnection, id);
            Model = itemModelConstructor.CreateItem(dbConnection, id);

            dbConnection.Close();
        }
    }
}
