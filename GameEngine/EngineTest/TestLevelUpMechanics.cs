﻿using GameEngine.CombatEngine;
using GameEngine.Equipment;
using GameEngine.EquipmentManagement;
using GameEngine.LevelUpMechanics;
using GameEngine.Player;
using GameEngine.Player.Specializatons.Mage;
using GameEngine.SpecializationMechanics.Rogue.Skills;
using GameEngine.Specializatons;
using System;

namespace EngineTest
{
    public class TestLevelUpMechanics
    {
        public TestLevelUpMechanics()
        {
            var specialization = new Mage();
            var specializationAttributes = new EntityModel_Mage();

            var wearedEquipment = new WearedEquipment(0);
            var equipmentValues = new EquipmentValue(wearedEquipment);

            var playerModelData = new PlayerModelData(specialization, GENDER.Male, "Gendalf_1", 10);

            var playerEntityConstructor = new PlayerEntityConstructor();
            var player1 = playerEntityConstructor.CreatePlayer(playerModelData, specializationAttributes, equipmentValues);

            Console.Write("level before level up: ");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(playerModelData.Level);
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("health before level up: ");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(player1.HealthPoints.Value);
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("stamina before level up: ");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(specializationAttributes.Stamina);
            Console.ForegroundColor = ConsoleColor.White;

            // level-up part
            var levelUpMechanics = new LevelUpManager(specializationAttributes, playerModelData);
            levelUpMechanics.UpgradeStamina();

            // player stats reconstruction
            player1 = playerEntityConstructor.CreatePlayer(playerModelData, specializationAttributes, equipmentValues);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\tLevel up\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("level after level up: ");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(playerModelData.Level);
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("health after level up: ");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(player1.HealthPoints.Value);
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("stamina after level up: ");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(specializationAttributes.Stamina);
            Console.ForegroundColor = ConsoleColor.White;

            var backstab = new Backstab();
 

            Console.WriteLine(backstab.SkillLevel);
            Console.WriteLine(backstab.AmountOfValue);

            backstab.SkillLevel = 2;

            Console.WriteLine(backstab.SkillLevel);
            Console.WriteLine(backstab.AmountOfValue);

        }
    }
}
