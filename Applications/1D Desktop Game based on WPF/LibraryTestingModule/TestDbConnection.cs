using GameEngine.Equipment;
using GameEngine.Equipment.Db.Services;
using GameEngine.Inventory;
using System;

namespace EngineTest
{
    public class TestDbConnection
    {
        public TestDbConnection()
        {
            var playerInventory = new PlayerInventoryItemsList();
            playerInventory.AddItem(new ItemEntity(15));

            Console.WriteLine("Item description\n");

            foreach (var attributeDescription in playerInventory.GetDescription(15))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(attributeDescription.Key + ": ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t" + attributeDescription.Value);
            }

            Console.ForegroundColor = ConsoleColor.White;

            var dbConnection = new DbConnectionService();

            Console.WriteLine("\nAll items in database\n");

            foreach (var itemDescription in dbConnection.GetItemsList())
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("Item name: \t" + itemDescription.ItemName);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\t\twear type: " + itemDescription.WearType);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("\t\tID: " + itemDescription.ID);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tquality: " + itemDescription.Quality);
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
