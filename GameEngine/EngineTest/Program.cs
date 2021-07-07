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
    class Program
    {
        public static decimal benchmarkCount = 0;
        static void Main(string[] args)
        {
            var regularAttack = new RegularAttack();
            var fireball = new Fireball(3);
            var heal = new Heal(3);
            var magicShield = new MagicShield(5);


            var player1 = GetPlayer("Gendalf", "male", 1);
            var player2 = GetPlayer("Jandalf", "shemale", 1);

            RunTest(player1, player2, skill1: heal, skill2: fireball, cyclesCount: 10000);
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

        private static void RunTest(PlayerEntity player1, PlayerEntity player2, ISkill skill1, ISkill skill2, int cyclesCount)
        {

            var player1CombatManager = new CombatManager(dealer: player1, target: player2);
            var player2CombatManager = new CombatManager(dealer: player2, target: player1);

            var logService = new LogService(player1CombatManager, player2CombatManager);

            logService.Log += Notification;


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

        private static PlayerEntity GetPlayer(string name, string gender, uint level)
        {
            var playerEntityConstructor = new PlayerEntityConstructor();

            var specialization = new Mage();
            var specializationAttributes = new MageBasicAttributes();
            var wearedEquipment = new WearedEquipment(2);
            var equipmentValues = new EquipmentValue(wearedEquipment);

            var player1Entity = playerEntityConstructor.CreatePlayer(new PlayerGlobalData(specialization, gender, name, level), specializationAttributes, equipmentValues);
            return player1Entity;
        }
    }
}
