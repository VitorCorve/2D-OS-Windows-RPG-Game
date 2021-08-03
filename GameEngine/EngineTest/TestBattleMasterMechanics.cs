using GameEngine.BattleMaster;
using GameEngine.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineTest
{
    public class TestBattleMasterMechanics
    {
        public TestBattleMasterMechanics()
        {
            var loadGameService = new LoadGameService();

            var newPlayerData = loadGameService.Load("Ralof_2");
            var battleMaster = new BattleMaster(newPlayerData);
            battleMaster.StartFight();

            foreach (var item in battleMaster.Observers)
            {
                item.Log += Notification;
            }
            Console.ReadLine();
        }
        private static void Notification(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
