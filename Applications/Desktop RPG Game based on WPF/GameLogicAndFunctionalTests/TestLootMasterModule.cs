using GameEngine.Data.Services;
using GameEngine.LootMaster;
using System;

namespace GameLogicAndFunctionalTests
{
    class TestLootMasterModule
    {
        public TestLootMasterModule()
        {
            var loadGameService = new LoadGameService();
            var playerLoadData = loadGameService.Load("Ralof_3");

            playerLoadData.PlayerModel.Level = 10;

            var lootMaster = new LootMaster(playerLoadData);

            Console.WriteLine("Player inventory items before looting: ");

            foreach (var item in playerLoadData.Inventory.ItemsInInventory)
                Console.WriteLine("\t" + item.Model.ItemName);
            Console.Write("\tMoney: " + playerLoadData.PlayerModel.PlayerConsumables.AbsoluteMoneyValue);

            lootMaster.ThrowItems();

            Console.WriteLine("\nLoot: ");
            foreach (var item in lootMaster.Loot)
            {
                Console.WriteLine(item.Model.ItemName);
            }
            Console.Write("Money: " + lootMaster.MoneyReward + "\n");

            for (int i = 0; i < lootMaster.Loot.Count; i++)
                lootMaster.PickUpItem(i);

            Console.WriteLine("\nPlayer inventory items after looting: ");

            foreach (var item in playerLoadData.Inventory.ItemsInInventory)
                Console.WriteLine("\t" + item.Model.ItemName);
            Console.Write("\tMoney: " + playerLoadData.PlayerModel.PlayerConsumables.AbsoluteMoneyValue);
        }
    }
}
