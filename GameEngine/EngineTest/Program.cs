using GameEngine;
using GameEngine.Player;
using GameEngine.CombatEngine;
using GameEngine.Specializatons;
using System;
using GameEngine.EquipmentManagement;
using GameEngine.Player.Specializatons.Mage;

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
            var equipmentvalues = new EquipmentInstance();

            var playerEntity = playerEntityConstructor.CreatePlayer(new PlayerMeta(specialization, gender, characterName, level), specializationAttributes, equipmentvalues);

            Console.WriteLine(playerEntity.AttackPower);
        }
    }
}
