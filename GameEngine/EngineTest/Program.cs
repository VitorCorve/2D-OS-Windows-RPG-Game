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
using GameEngine.CombatEngine.Managers;

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

            var player1Entity = playerEntityConstructor.CreatePlayer(new PlayerGlobal(specialization, gender, characterName, level), specializationAttributes, equipmentValues);
            var player2Entity = playerEntityConstructor.CreatePlayer(new PlayerGlobal(specialization, gender, characterName, level), specializationAttributes, equipmentValues);

            Console.WriteLine("player1 hp: " + player1Entity.HealthPoints);

            Console.WriteLine("player2 attackPower: " + player2Entity.AttackPower);
            Console.WriteLine("player1 mp: " + player1Entity.ManaPoints.Value);

            var player1CombatService = new CombatServiсe(player1Entity);
            var player1ReadyToAttackService = new ReadyToAttackService(player1Entity);

            player1ReadyToAttackService.Log += Notification;

            var regularAttack = new RegularAttack();
            var fireball = new Fireball(3);

            var player2defenseService = new DefenseService(player2Entity);

            player1CombatService.Prepare(

                () => player1ReadyToAttackService.CheckStatement(fireball),
                () => player1Entity.ReduceResource(fireball),
                () => player2defenseService.DefenseCheck(fireball),
                () => player1CombatService.Execute(player2Entity, fireball)

                );

            Console.WriteLine("player1 hp after attack: " + player2Entity.HealthPoints );
            Console.WriteLine("player1 mp after attack: " + player1Entity.ManaPoints.Value);
        }

        private static void Notification(string message)
        {
            Console.WriteLine(message);
        }

    }
}
