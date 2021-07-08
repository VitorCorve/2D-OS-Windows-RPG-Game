using GameEngine;
using GameEngine.Player;
using GameEngine.CombatEngine;
using System.Timers;
using GameEngine.Specializatons;
using System;
using GameEngine.EquipmentManagement;
using GameEngine.Player.Specializatons.Mage;
using GameEngine.Equipment;
using GameEngine.SpecializationMechanics.Mage;
using GameEngine.SpecializationMechanics.Mage.Skills;
using GameEngine.SpecializationMechanics.GlobalSkills;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Services;

namespace EngineTest
{
    public class TestCombatServices
    {
        public static decimal benchmarkCount = 0;
        public void Run(PlayerGlobalData player1Data, PlayerGlobalData player2Data, PlayerEntity player1, PlayerEntity player2, ISkill skill1, ISkill skill2, int cyclesCount)
        {
            var player1CombatManager = new CombatManager(dealer: player1, target: player2);
            var player2CombatManager = new CombatManager(dealer: player2, target: player1);

            var observerService = new ObserverService(player1CombatManager, player1Data, player2Data);
            var observerService2 = new ObserverService(player2CombatManager, player2Data, player1Data);

            observerService.Log += Notification;
            observerService2.Log += Notification;

            var benchmarkTimer = new Timer(100);
            benchmarkTimer.Elapsed += BenchmarkTick;
            benchmarkTimer.Start();


            for (int i = 1; i <= cyclesCount; i++)
            {
                Console.Write("\nCycle ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(i);
                Console.ForegroundColor = ConsoleColor.White;

                player1CombatManager.Action(skill1);

                Console.Write($"\nplayer 1 hp after ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(skill1.SkillName);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($": {player1.HealthPoints.Value}");

                Console.Write($"player 1 mp after ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(skill1.SkillName);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($": {player1.ManaPoints.Value}");



                Console.Write($"player 2 attack power before ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(skill1.SkillName);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($": {player1.AttackPower}");

                player2CombatManager.Action(skill2);

                Console.Write($"player 1 hp after ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(skill2.SkillName);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($": {player1.HealthPoints.Value}");



                Console.Write($"player 1 armor ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(skill2.SkillName);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($": {player1.ArmorPoints.Value}");
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
