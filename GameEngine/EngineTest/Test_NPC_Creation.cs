using GameEngine.CombatEngine;
using GameEngine.NPC;
using GameEngine.Player;
using GameEngine.Specializatons;

namespace EngineTest
{
    public class Test_NPC_Creation
    {
        public Test_NPC_Creation()
        {
            var specialization = new Mage();
            var playerModelData = new PlayerModelData(specialization, GENDER.Male, "Gendalf_1", 30, 100);

            var npcCreationManager = new NPC_CreationManager(playerModelData);

            var playerEntityConstructor = new PlayerEntityConstructor();

            var playerEntity = playerEntityConstructor.CreatePlayer(
                npcCreationManager.NPC_Model, 
                npcCreationManager.NPC);

            System.Console.ForegroundColor = System.ConsoleColor.Cyan;
            System.Console.WriteLine("\n\tPlayer:\n");
            System.Console.ForegroundColor = System.ConsoleColor.White;

            System.Console.WriteLine("player grade: " + playerModelData.PlayerGrade);
            System.Console.WriteLine($"player level: {playerModelData.Level}");

            System.Console.ForegroundColor = System.ConsoleColor.Cyan;
            System.Console.WriteLine("\n\tEnemy:\n");
            System.Console.ForegroundColor = System.ConsoleColor.White;

            System.Console.WriteLine("npc level: " + npcCreationManager.NPC_Model.Level);
            System.Console.WriteLine("npc name: " + npcCreationManager.NPC_Model.Name);
            System.Console.WriteLine("npc specialization(race/type): \t" + npcCreationManager.NPC_Model.NPC_Type);
            System.Console.WriteLine($"enemy healthpoints {playerEntity.HealthPoints.Value}");
            System.Console.WriteLine($"enemy attack power {playerEntity.Attack.Value}");
        }
    }
}
