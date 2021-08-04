using GameEngine.BattleMaster;
using GameEngine.Data;
using GameEngine.Data.Services;
using GameEngine.LevelUpMechanics.Services;
using GameEngine.Player;
using System;

namespace EngineTest
{
    public class TestBattleMasterMechanics
    {
        public TestBattleMasterMechanics()
        {

            var loadGameService = new LoadGameService();
            var playerData = loadGameService.Load("Wulfgar_1");

            var availableskills = new GetAvailablePlayerSkills(playerData.PlayerModel);
            var skillLevelUpService = new SkillLevelUpService(playerData.PlayerModel, playerData.ListOfSkills);


            var battleMaster = new BattleMaster(playerData);

            battleMaster.StartFight();

            foreach (var item in battleMaster.Observers)
            {
                item.Log += Notification;
            }

            battleMaster.UseSkill(0);

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
