using GameEngine.Equipment;
using GameEngine.Inventory;
using GameEngine.MerchantMechanics;
using GameEngine.Player;
using System;

namespace GameLogicAndFunctionalTests
{
    public class TestMerchantModule
    {
        public TestMerchantModule()
        {
            var playerConsumables = new PlayerConsumablesData(1050);
            var merchantConsumables = new PlayerConsumablesData(100000);
            var playerInventory = new PlayerInventoryItemsList();
            var merchantInventory = new MerchantInventoryItemsList();

            var tradeManager = new TradeManager(playerConsumables, merchantConsumables, playerInventory, merchantInventory);

            var item = new ItemEntity(0);
            tradeManager.ItemToTrade = item;

            playerInventory.AddItem(new ItemEntity(0));
            merchantInventory.AddItem(new ItemEntity(0));
            merchantInventory.AddItem(new ItemEntity(1));
            merchantInventory.AddItem(new ItemEntity(2));

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("merchant inventory before deal: \n");

            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var merchantItems in merchantInventory.ItemsInInventoryDescription)
            {
                Console.WriteLine(merchantItems.Key.Model.ItemName);
            }

            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nplayer inventory before deal: \n");


            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var playerItems in playerInventory.ItemsInInventory)
            {
                Console.WriteLine(playerItems.Model.ItemName);
            }

            ////////////////////////////////////////
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n/////////////////////////////////\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("player money balance in coppers: ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(playerConsumables.AbsoluteMoneyValue);
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\nmerchant money balance in coppers: ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(merchantConsumables.AbsoluteMoneyValue);
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\nitem cost in coppers: ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(item.Model.Price.AbsoluteMoneyValue);
            Console.ForegroundColor = ConsoleColor.White;

            ////////////////////////////////////////
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n/////////////////////////////////\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write($"\tplayer sells: ");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(item.Model.ItemName);
            Console.ForegroundColor = ConsoleColor.White;

            ////////////////////////////////////////
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n/////////////////////////////////\n");
            Console.ForegroundColor = ConsoleColor.White;

            tradeManager.Sell();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Item description\n");

            foreach (var attributeDescription in playerInventory.GetDescription(0))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(attributeDescription.Key + ": ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t" + attributeDescription.Value);
            }

            ////////////////////////////////////////
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n/////////////////////////////////\n");
            Console.ForegroundColor = ConsoleColor.White;


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nplayer inventory after deal: \n");

            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var playerItems in playerInventory.ItemsInInventory)
            {
                Console.WriteLine(playerItems.Model.ItemName);
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nmerchant inventory after deal: \n");

            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var merchantItems in merchantInventory.ItemsInInventoryDescription)
            {
                Console.WriteLine(merchantItems.Key.Model.ItemName);
            }

            ////////////////////////////////////////
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n/////////////////////////////////\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("player money balance in coppers after deal: ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(playerConsumables.AbsoluteMoneyValue);
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\nmerchant money balance in coppers after deal: ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(merchantConsumables.AbsoluteMoneyValue);

            ////////////////////////////////////////
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n/////////////////////////////////\n");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
