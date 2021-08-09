using GameEngine.Equipment.Db.Services;
using GameEngine.Equipment.Resource;

namespace GameEngine.Equipment
{
    public class ItemEntity
    {
        public ItemAttributes Attributes { get; private set; }
        public ItemModel Model { get; private set; }
        public Durability ItemDurability { get; set; } = new();
        public ItemEntity(int id)
        {
            var itemAttributesConstructor = new ItemAttributesConstructor();
            var itemModelConstructor = new ItemModelConstructor();
            var dbConnection = new DbConnectionService();

            Attributes = itemAttributesConstructor.CreateItem(dbConnection, id);
            Model = itemModelConstructor.CreateItem(dbConnection, id);
            dbConnection.Close();

            ItemDurability.Value = 100;
        }
        public ItemEntity(int id, int itemDurability)
        {
            var itemAttributesConstructor = new ItemAttributesConstructor();
            var itemModelConstructor = new ItemModelConstructor();
            var dbConnection = new DbConnectionService();

            Attributes = itemAttributesConstructor.CreateItem(dbConnection, id);
            Model = itemModelConstructor.CreateItem(dbConnection, id);
            dbConnection.Close();

            ItemDurability.Value = itemDurability;
        }
    }
}
