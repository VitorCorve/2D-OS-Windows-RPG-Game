using GameEngine.Player;
using GameEngine.CombatEngine;
using System.Timers;
using System;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Services;
using GameEngine.CombatEngine.Interfaces.SkillMechanics;

namespace EngineTest
{
    public class TestCombatServices
    {
        public static decimal benchmarkCount = 0;
        public void Run(PlayerGlobalData player1Data, PlayerGlobalData player2Data, PlayerEntity player1, PlayerEntity player2, ISkill skill1, ISkill skill2, int cyclesCount, double iterationsInterval)
        {
            double _iterationsInterval = 1000 * iterationsInterval;
            var player1CombatManager = new CombatManager(dealer: player1, target: player2);
            var player2CombatManager = new CombatManager(dealer: player2, target: player1);

            var observerService = new ObserverService(player1CombatManager, player1Data, player2Data);
            var observerService2 = new ObserverService(player2CombatManager, player2Data, player1Data);

            var specialAbilitiesObserver = new SpecialAbilitiesObserverService(player1, skill1);

            observerService.Log += Notification;
            observerService2.Log += Notification;

            var benchmarkTimer = new Timer(100);
            benchmarkTimer.Elapsed += BenchmarkTick;
            benchmarkTimer.Start();

/*            var findTheWeakness = new GameEngine.SpecializationMechanics.Rogue.Skills.FindTheWeakness(1);
            player1CombatManager.Action(findTheWeakness);*/

            for (int i = 1; i <= cyclesCount; i++)
            {
                Console.Write("\nCycle ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(i + "\n");
                Console.ForegroundColor = ConsoleColor.White;

                // player 1 action

                Console.Write($"{player2Data.Name} 1 hp before ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(skill2.SkillName);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($": {player2.HealthPoints.Value}");

                player1CombatManager.Action(skill1);

                Console.Write($"{player2Data.Name} 1 hp after ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(skill2.SkillName);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($": {player2.HealthPoints.Value}");

                Console.WriteLine(((ISkillDuration)skill1).Duration);

                Console.Write($"{player2Data.Name} 1 armor ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(skill2.SkillName);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($": {player2.ArmorPoints.Value}");


                // player 2 action

                Console.Write($"{player1Data.Name} 1 hp before ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(skill2.SkillName);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($": {player1.HealthPoints.Value}");

                player2CombatManager.Action(skill2);

                Console.Write($"{player1Data.Name} 1 hp after ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(skill2.SkillName);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($": {player1.HealthPoints.Value}");



                Console.Write($"{player1Data.Name} 1 armor ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(skill2.SkillName);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($": {player1.ArmorPoints.Value}");

                System.Threading.Thread.Sleep((int)_iterationsInterval);
            }

            benchmarkTimer.Stop();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\nSeconds passed: " + benchmarkCount / 100 + " s.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void BenchmarkTick(object sender, ElapsedEventArgs e)
        {
            benchmarkCount += 10;
        }

        private static void Notification(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
