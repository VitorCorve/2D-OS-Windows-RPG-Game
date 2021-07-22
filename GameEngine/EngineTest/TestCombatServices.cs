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
using GameEngine.NPC;

namespace EngineTest
{
    public class TestCombatServices
    {
        public static decimal benchmarkCount = 0;

        public TestCombatServices()
        {
            var regularAttack = new RegularAttack();

            // mage skills. Every players entity must have their own skills exemplar
            var fireball = new Fireball();
            var heal = new Heal();
            var magicShield = new MagicShield();
            var polymorph = new Polymorph();
            var polymorph2 = new Polymorph();
            var soulburn = new Soulburn();
            var soulburn2 = new Soulburn();


            // rogue skills
            var backstab = new Backstab();
            var dissapearIntoTheShadows = new DissapearIntoTheShadows();
            var findTheWeakness = new FindTheWeakness();
            var rend = new Rend();
            var stun = new Stun();

            // warrior skills
            var crushLegs = new CrushLegs();
            var deepDefense = new DeepDefense();
            var lastManStanding = new LastManStanding();
            var powerHit = new PowerHit();
            var wideBlow = new WideBlow();

            var playerEntityConstructor = new PlayerEntityConstructor();

            var specialization = new Mage();
            var specializationAttributes = new EntityModel_Mage();
            var specializationAttributes2 = new EntityModel_Rogue();
            var wearedEquipment = new WearedEquipment(0);
            var equipmentValues = new EquipmentValue(wearedEquipment);

            var player1ModelData = new PlayerModelData(specialization, GENDER.Male, "Gendalf_1", 50);
            /*var player2ModelData = new PlayerModelData(specialization, GENDER.Male, "Ralof_2", 1);*/

            // creating NPC

            var npcCreationManager = new NPC_CreationManager(player1ModelData);

            var npcEntityConstructor = new PlayerEntityConstructor();

            var npcEntity = npcEntityConstructor.CreatePlayer(
                npcCreationManager.NPC_Model,
                npcCreationManager.NPC);

            var player1 = playerEntityConstructor.CreatePlayer(player1ModelData, specializationAttributes, equipmentValues);
            /*var player2 = playerEntityConstructor.CreatePlayer(player2GlobalData, specializationAttributes2, equipmentValues);*/


            Run(
                player1ModelData,
                npcCreationManager.NPC_Model,
                player1: player1,
                player2: npcEntity,
                skill1: powerHit,
                skill2: wideBlow,
                cyclesCount: 100,
                iterationsInterval: 0);
        }
   
        // player VS player Run method overload
        public void Run(PlayerModelData player1Data, PlayerModelData player2Data, PlayerEntity player1, PlayerEntity player2, ISkill skill1, ISkill skill2, int cyclesCount, double iterationsInterval)
        {
            double _iterationsInterval = 1000 * iterationsInterval;
            var player1CombatManager = new CombatManager(dealer: player1, target: player2);
            var player2CombatManager = new CombatManager(dealer: player2, target: player1);

            var observerService = new ObserverService(player1CombatManager, player1Data, player2Data);
            var observerService2 = new ObserverService(player2CombatManager, player2Data, player1Data);

            var specialAbilitiesObserver = new SpecialAbilitiesObserverService(player1, skill1);

            var lastManStanding = new LastManStanding();

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

        // player VS NPC Run method overload
        public void Run(PlayerModelData player1Data, NPC_ModelData player2Data, PlayerEntity player1, PlayerEntity player2, ISkill skill1, ISkill skill2, int cyclesCount, double iterationsInterval)
        {
            double _iterationsInterval = 1000 * iterationsInterval;
            var player1CombatManager = new CombatManager(dealer: player1, target: player2);
            var player2CombatManager = new CombatManager(dealer: player2, target: player1);

            var observerService = new ObserverService(player1CombatManager, player1Data, player2Data);
            var observerService2 = new ObserverService(player2CombatManager, player2Data, player1Data);

            var specialAbilitiesObserver = new SpecialAbilitiesObserverService(player1, skill1);

            var lastManStanding = new LastManStanding();

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
