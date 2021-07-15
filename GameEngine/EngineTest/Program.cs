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
using GameEngine.SpecializationMechanics.Rogue.Skills;
using GameEngine.Player.Specializatons.Rogue;
using GameEngine.SpecializationMechanics.Warrior.Skills;

namespace EngineTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new TestCombatServices();

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

            var playerEntityConstructor = new PlayerEntityConstructor();

            var specialization = new Mage();
            var specializationAttributes = new MageBasicAttributes();
            var specializationAttributes2 = new RogueBasicAttributes();
            var wearedEquipment = new WearedEquipment(2);
            var equipmentValues = new EquipmentValue(wearedEquipment);

            var player1GlobalData = new PlayerGlobalData(specialization, "male", "Gendalf_1", 1);
            var player2GlobalData = new PlayerGlobalData(specialization, "male", "Ralof_2", 1);

            var player1 = playerEntityConstructor.CreatePlayer(player1GlobalData, specializationAttributes, equipmentValues);
            var player2= playerEntityConstructor.CreatePlayer(player2GlobalData, specializationAttributes2, equipmentValues);


            test.Run(
                player1GlobalData, 
                player2GlobalData, 
                player1: player1, 
                player2: player2, 
                skill1: deepDefense, 
                skill2: regularAttack, 
                cyclesCount: 1000, 
                iterationsInterval: 1);
        }


    }
}
