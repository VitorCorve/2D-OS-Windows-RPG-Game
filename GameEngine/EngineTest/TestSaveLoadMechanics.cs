using System;
using GameEngine.Data.Services;
using GameEngine.Data;
using GameEngine.Equipment;
using GameEngine.Inventory;
using GameEngine.Player;
using GameEngine.Specializatons;
using GameEngine.LevelUpMechanics.Services;
using GameEngine.SpecializationMechanics.Mage.Skills;

namespace EngineTest
{
    public class TestSaveLoadMechanics
    {
        public TestSaveLoadMechanics()
        {
            Load();
        }
        public void Load()
        {
            var loadGameService = new LoadGameService();

            var newPlayerData = loadGameService.Load("Wulfgar_2");

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
            Console.WriteLine(newPlayerData.PlayerModel.PlayerConsumables.AbsoluteMoneyValue);

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n\tInventory item list:");
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var item in newPlayerData.Inventory.ItemsInInventory)
            {
                Console.WriteLine(item.Model.ItemName);
            }
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n\tWeared by character items list:");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            foreach (var item in newPlayerData.Equipment.ItemsList)
            {
                Console.WriteLine(item.Model.ItemName);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void Save()
        {
            var playerData = new PlayerSaveData();


            var wearedEquipment = new WearedEquipment(1, 2, 3);
            var playerInventory = new PlayerInventoryItemsList();
            var playerSpecialization = new Mage();
            var playerModelData = new PlayerModelData(playerSpecialization, GENDER.Male, "Ralof_3", 50, money: 100);
            var playerSkills = new PlayerSkillList();

            playerInventory.AddItem(new ItemEntity(4));
            playerInventory.AddItem(new ItemEntity(5));
            playerInventory.AddItem(new ItemEntity(6));

            playerData.ItemsOnCharacter.PrepareToSerialize(wearedEquipment.ItemsList);
            playerData.ItemsInInventory.PrepareToSerialize(playerInventory.ItemsInInventory);
            playerData.Gender = playerModelData.Gender;
            playerData.Skills = playerSkills;
            playerData.Specialization = SPECIALIZATION.Mage;
            playerData.Level = playerModelData.Level;
            playerData.Name = playerModelData.Name;
            playerData.Money = playerModelData.PlayerConsumables.AbsoluteMoneyValue;

            var skillLevelUpService = new SkillLevelUpService(playerModelData, playerData.Skills);

            var fireball = new Fireball();
            var heal = new Heal();
            var magicShield = new MagicShield();
            var polymorph = new Polymorph();
            var soulburn = new Soulburn();

            fireball.SkillLevel = 1;
            heal.SkillLevel = 1;
            magicShield.SkillLevel = 1;
            polymorph.SkillLevel = 1;
            soulburn.SkillLevel = 1;

            skillLevelUpService.LearnDirectly(fireball);
            skillLevelUpService.LearnDirectly(heal);
            skillLevelUpService.LearnDirectly(magicShield);
            skillLevelUpService.LearnDirectly(polymorph);
            skillLevelUpService.LearnDirectly(soulburn);

            var saveGameService = new SaveGameService();
            saveGameService.Save(playerData);
        }
        public void AlternativeSave()
        {
            var loadGameService = new LoadGameService();

            var newPlayerData = loadGameService.Load("Ralof_3");

            newPlayerData.PlayerModel.Name = "Wulfgar_2";

            var saveGameService = new SaveGameService();
            saveGameService.Save(newPlayerData);
        }
    }
}
