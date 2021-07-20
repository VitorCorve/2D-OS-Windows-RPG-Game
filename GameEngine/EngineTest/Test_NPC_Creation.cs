using GameEngine.CombatEngine;
using GameEngine.Equipment;
using GameEngine.EquipmentManagement;
using GameEngine.NPC;
using GameEngine.Player;
using GameEngine.Specializatons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineTest
{
    public class Test_NPC_Creation
    {
        public Test_NPC_Creation()
        {
            var specialization = new Mage();
            var playerModelData = new PlayerModelData(specialization, "male", "Gendalf_1", 1);

            var npcCreationManager = new NPC_CreationManager(playerModelData);

            var wearedEquipment = new WearedEquipment(2);
            var equipmentValues = new EquipmentValue(wearedEquipment);

            var playerEntityConstructor = new PlayerEntityConstructor();

            playerEntityConstructor.CreatePlayer(
                npcCreationManager.NPC_Model, 
                npcCreationManager.NPC, 
                equipmentValues);
        }
    }
}
