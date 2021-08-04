using System;
using GameEngine.Data.Services;
using GameEngine.Data;
using GameEngine.Equipment;
using GameEngine.Inventory;
using GameEngine.Player;
using GameEngine.Specializatons;


namespace EngineTest
{
    public class TestSaveLoadMechanics
    {
        public TestSaveLoadMechanics()
        {
            var playerData = new PlayerSaveData();

            var wearedEquipment = new WearedEquipment(1,2);
            var playerInventory = new PlayerInventoryItemsList();
            var playerSpecialization = new Mage();
            var playerModelData = new PlayerModelData(playerSpecialization, GENDER.Male, "Ralof_2", 50, money: 100);
            var playerSkills = new PlayerSkillList();

            playerData.Equipment = wearedEquipment;
            playerData.Inventory = playerInventory;
            playerData.Gender = playerModelData.Gender;
            playerData.Skills = playerSkills;
            playerData.Specialization = "mage";
            playerData.Level = playerModelData.Level;
            playerData.Name = playerModelData.Name;
            playerData.ItemsList = wearedEquipment.ItemsList;
            playerData.Money = playerModelData.PlayerConsumablesData.AbsoluteMoneyValue;


            var saveGameService = new SaveGameService();
            // saveGameService.Save(playerData);

            var loadGameService = new LoadGameService();
            
            var newPlayerData = loadGameService.Load("Ralof_2");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"\n\tCharacter {newPlayerData.PlayerModel.Name} loaded\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Name: \t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(newPlayerData.PlayerModel.Name);


            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Level: \t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(newPlayerData.PlayerModel.Level);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Location: \t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(newPlayerData.PlayerModel.CurrentLand);


            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Gender: \t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(newPlayerData.PlayerModel.Gender);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Player grade: \t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(newPlayerData.PlayerModel.PlayerGrade);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Specialization: \t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(newPlayerData.PlayerModel.Specialization);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Money: \t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(newPlayerData.PlayerModel.PlayerConsumablesData.AbsoluteMoneyValue);
        }
    }
}
