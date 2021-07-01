using GameEngine;
using GameEngine.Player;
using GameEngine.CombatEngine;
using GameEngine.Specializatons;
using System;
using GameEngine.EquipmentManagement;
using GameEngine.Player.Specializatons.Mage;
using GameEngine.Equipment;

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

            var playerEntity = playerEntityConstructor.CreatePlayer(new PlayerGlobal(specialization, gender, characterName, level), specializationAttributes, equipmentValues);
            var playerEntity2 = playerEntityConstructor.CreatePlayer(new PlayerGlobal(specialization, gender, characterName, level), specializationAttributes, equipmentValues);

            Console.WriteLine(" player1 hp: " + playerEntity.HealthPoints);

            Console.WriteLine(" player2 attackPower: " + playerEntity2.AttackPower);

            var player1CombatService = new CombatServiсe(playerEntity);

            player1CombatService.Prepare(() => player1CombatService.Execute(playerEntity2));
           
            Console.WriteLine(" player1 hp after attack: " + playerEntity2.HealthPoints );

        }
    }
}
