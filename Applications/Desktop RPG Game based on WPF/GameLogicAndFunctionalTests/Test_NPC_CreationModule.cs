using GameEngine.CombatEngine;
using GameEngine.NPC;
using GameEngine.Player;
using GameEngine.Specializatons;
using System;

namespace GameLogicAndFunctionalTests
{
    public class Test_NPC_CreationModule
    {
        public Test_NPC_CreationModule()
        {
            var specialization = new Mage();
            var playerModelData = new PlayerModelData(specialization, GENDER.Male, "Gendalf_1", 30, 100);

            var npcCreationManager = new NPC_CreationManager(playerModelData);

            var playerEntityConstructor = new PlayerEntityConstructor();

            var playerEntity = playerEntityConstructor.CreatePlayer(
                npcCreationManager.NPC_Model,
                npcCreationManager.NPC);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\tPlayer:\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("player grade: " + playerModelData.PlayerGrade);
            Console.WriteLine($"player level: {playerModelData.Level}");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\tEnemy:\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("npc level: " + npcCreationManager.NPC_Model.Level);
            Console.WriteLine("npc name: " + npcCreationManager.NPC_Model.Name);
            Console.WriteLine("npc specialization(race/type): \t" + npcCreationManager.NPC_Model.NPC_Type);
            Console.WriteLine($"enemy healthpoints {playerEntity.HealthPoints.Value}");
            Console.WriteLine($"enemy attack power {playerEntity.Attack.Value}");
        }
    }
}
