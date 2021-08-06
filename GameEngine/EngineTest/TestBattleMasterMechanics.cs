using GameEngine.BattleMaster;
using GameEngine.CombatEngine.Interfaces.SkillMechanics;
using GameEngine.CombatEngine.Services;
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
            var skillEffectObserver = new SkillEffectObserver(playerData);


            var battleMaster = new BattleMaster(playerData);

            battleMaster.StartFight();

            foreach (var item in battleMaster.Observers)
            {
                item.Log += Notification;
            }

            battleMaster.UseSkill(0);



            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine("Player cooldowns:\n");
                foreach (var item in skillEffectObserver.DealerCoolDowns)
                {
                    Console.WriteLine($"Skill name: {item.SkillName}\t Skill ID: {item.Skill_ID}\t Skill cooldown: {item.CoolDown}");
                }

                Console.WriteLine("\nPlayer buffs:\n");
                foreach (var item in skillEffectObserver.EffectsOnDealer)
                {
                    Console.WriteLine($"Skill name: {item.SkillName}\t Skill ID: {item.Skill_ID}\t Buff duration: {((ISkillDuration)item).ActiveDuration}");
                }

                System.Threading.Thread.Sleep(1000);
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
