using GameEngine.Equipment;
using GameEngine.MerchantMechanics;
using GameEngine.MerchantMechanics.Services;
using GameEngine.Player;
using System;

namespace EngineTest
{
    public class TestMerchantMechanics
    {
        public TestMerchantMechanics()
        {
            var playerConsumables = new PlayerConsumablesData(1050);
            var tradeManager = new TradeManager(playerConsumables);

            var item = new ItemEntity(0);
            tradeManager.ItemToTrade = item;

            Console.Write("player money balance in coppers: ");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(playerConsumables.AbsoluteMoneyValue);
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\nitem cost in coppers: ");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(item.Model.Cost.AbsoluteMoneyValue);
            Console.ForegroundColor = ConsoleColor.White;

            tradeManager.Sell();

            Console.Write("\nplayer money balance in coppers: ");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(playerConsumables.AbsoluteMoneyValue);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
