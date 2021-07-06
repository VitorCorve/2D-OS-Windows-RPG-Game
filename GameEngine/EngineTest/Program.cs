using GameEngine;
using GameEngine.Player;
using GameEngine.CombatEngine;

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
        static void Main(string[] args)
        {
            var playerEntityConstructor = new PlayerEntityConstructor();

            string characterName = "Gendalf";
            string gender = "male";
            uint level = 1;

            var specialization = new Mage();
            var specializationAttributes = new MageBasicAttributes();
            var wearedEquipment = new WearedEquipment(1);
            var equipmentValues = new EquipmentValue(wearedEquipment);

            var player1Entity = playerEntityConstructor.CreatePlayer(new PlayerGlobalData(specialization, gender, characterName, level), specializationAttributes, equipmentValues);
            var player2Entity = playerEntityConstructor.CreatePlayer(new PlayerGlobalData(specialization, gender, characterName, level), specializationAttributes, equipmentValues);

            Console.WriteLine("\nplayer 1 hp: " + player1Entity.HealthPoints);

            Console.WriteLine("\nplayer 2 attackPower: " + player2Entity.AttackPower);
            Console.WriteLine("\nplayer 1 mp: " + player1Entity.ManaPoints.Value);
            Console.WriteLine("\nplayer 1 armor: " + player1Entity.ArmorPoints.Value);

            var regularAttack = new RegularAttack();
            var fireball = new Fireball(3);
            var heal = new Heal(3);
            var magicShield = new MagicShield(5);

            var player1CombatManager = new CombatManager(dealer: player1Entity, target: player2Entity);
            var player2CombatManager = new CombatManager(dealer: player2Entity, target: player1Entity);


            player1CombatManager.Action(magicShield);
            player1CombatManager.Action(heal);

            Console.WriteLine("\n///////////////");

            Console.WriteLine("\nplayer 2 hp after attack: " + player2Entity.HealthPoints );
            Console.WriteLine("\nplayer 1 hp after heal: " + player1Entity.HealthPoints );
            Console.WriteLine("\nplayer 1 mp after attack: " + player1Entity.ManaPoints.Value);
            Console.WriteLine("\nplayer 1 armor after magic shield: " + player1Entity.ArmorPoints.Value);

            Console.WriteLine("\n///////////////");

            for (int i = 0; i < 100; i++)
            {
                player1CombatManager.Action(heal);
                Console.WriteLine("\nplayer 1 hp after heal: " + player1Entity.HealthPoints);
                player2CombatManager.Action(regularAttack);
                Console.WriteLine("\nplayer 1 hp after attack: " + player1Entity.HealthPoints);


            }
        }

        private static void Notification(string message)
        {
            Console.WriteLine(message);
        }

    }
}
