using GameEngine.Player;
using GameEngine.CombatEngine;
using System.Timers;
using System;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Services;
using GameEngine.CombatEngine.Interfaces.SkillMechanics;
using GameEngine.SpecializationMechanics.Warrior.Skills;
using GameEngine.SpecializationMechanics.UniversalSkills;
using GameEngine.SpecializationMechanics.Mage.Skills;
using GameEngine.SpecializationMechanics.Rogue.Skills;
using GameEngine.Specializatons;
using GameEngine.Player.Specializatons.Mage;
using GameEngine.NPC.Specializations.Humans;
using GameEngine.Equipment;
using GameEngine.EquipmentManagement;

namespace EngineTest
{
    public class TestCombatServices
    {
        public static decimal benchmarkCount = 0;

        public TestCombatServices()
        {
            var regularAttack = new RegularAttack();

            // mage skills. Every players entity must have their own skills exemplar
            var fireball = new Fireball(3);
            var heal = new Heal(3);
            var magicShield = new MagicShield(5);
            var polymorph = new Polymorph(1);
            var polymorph2 = new Polymorph(1);
            var soulburn = new Soulburn(1);
            var soulburn2 = new Soulburn(1);


            // rogue skills
            var backstab = new Backstab(1);
            var dissapearIntoTheShadows = new DissapearIntoTheShadows(1);
            var findTheWeakness = new FindTheWeakness(1);
            var rend = new Rend(1);
            var stun = new Stun(1);

            // warrior skills
            var crushLegs = new CrushLegs(1);
            var deepDefense = new DeepDefense(8);
            var lastManStanding = new LastManStanding(5);
            var powerHit = new PowerHit(1);
            var wideBlow = new WideBlow(2);

            var playerEntityConstructor = new PlayerEntityConstructor();

            var specialization = new Mage();
            var specializationAttributes = new EntityModel_Mage();
            var specializationAttributes2 = new EntityModel_Rogue();
            var wearedEquipment = new WearedEquipment(2);
            var equipmentValues = new EquipmentValue(wearedEquipment);

            var player1GlobalData = new PlayerModelData(specialization, "male", "Gendalf_1", 1);
            var player2GlobalData = new PlayerModelData(specialization, "male", "Ralof_2", 1);

            var player1 = playerEntityConstructor.CreatePlayer(player1GlobalData, specializationAttributes, equipmentValues);
            var player2 = playerEntityConstructor.CreatePlayer(player2GlobalData, specializationAttributes2, equipmentValues);


            Run(
                player1GlobalData,
                player2GlobalData,
                player1: player1,
                player2: player2,
                skill1: wideBlow,
                skill2: powerHit,
                cyclesCount: 1000,
                iterationsInterval: 1);
        }
   
        public void Run(PlayerModelData player1Data, PlayerModelData player2Data, PlayerEntity player1, PlayerEntity player2, ISkill skill1, ISkill skill2, int cyclesCount, double iterationsInterval)
        {
            double _iterationsInterval = 1000 * iterationsInterval;
            var player1CombatManager = new CombatManager(dealer: player1, target: player2);
            var player2CombatManager = new CombatManager(dealer: player2, target: player1);

            var observerService = new ObserverService(player1CombatManager, player1Data, player2Data);
            var observerService2 = new ObserverService(player2CombatManager, player2Data, player1Data);

            var specialAbilitiesObserver = new SpecialAbilitiesObserverService(player1, skill1);

            var lastManStanding = new LastManStanding(5);

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
