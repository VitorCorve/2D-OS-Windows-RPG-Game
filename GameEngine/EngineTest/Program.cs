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
using GameEngine.SpecializationMechanics.UniversalSkills;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Services;

namespace EngineTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new TestCombatServices();

            var regularAttack = new RegularAttack();
            var fireball = new Fireball(3);
            var heal = new Heal(3);
            var magicShield = new MagicShield(5);
            var polymorph = new Polymorph(1);
            var polymorph2 = new Polymorph(1);
            var soulburn = new Soulburn(1);

            var playerEntityConstructor = new PlayerEntityConstructor();

            var specialization = new Mage();
            var specializationAttributes = new MageBasicAttributes();
            var wearedEquipment = new WearedEquipment(2);
            var equipmentValues = new EquipmentValue(wearedEquipment);

            var player1GlobalData = new PlayerGlobalData(specialization, "male", "Gendalf_1", 1);
            var player2GlobalData = new PlayerGlobalData(specialization, "male", "Ralof_2", 1);

            var player1 = playerEntityConstructor.CreatePlayer(player2GlobalData, specializationAttributes, equipmentValues);
            var player2= playerEntityConstructor.CreatePlayer(player1GlobalData, specializationAttributes, equipmentValues);


            test.Run(player1GlobalData, player2GlobalData, player1, player2, skill1: soulburn, skill2: soulburn, cyclesCount: 100, iterationsInterval: 0.1);
        }


    }
}
