using GameEngine.EquipmentManagement;
using GameEngine.Player;
using GameEngine.Player.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.CombatEngine
{
    public class PlayerEntityConstructor
    {

        public PlayerEntity CreatePlayer(PlayerMeta metaData, AbstractAttributes specializationAttributes, EquipmentInstance equipmentValues)
        {
            var playerEntity = new PlayerEntity();

            playerEntity.HealthPoints = (specializationAttributes.Stamina + equipmentValues.Stamina) * 10;
            playerEntity.ManaPoints = (specializationAttributes.Intellect + equipmentValues.Intellect) * 10;
            playerEntity.EnergyPoints = (specializationAttributes.Agility + equipmentValues.Agility) * 10;

            playerEntity.AttackPower = (specializationAttributes.Strength * 10) + equipmentValues.WeaponDamageValue;
            playerEntity.ArmorPoints = equipmentValues.ArmorValue * 10;

            if (metaData.Specialization != "mage")
            {
                playerEntity.CriticalHitChance = (specializationAttributes.Agility + metaData.Level);
            }
            else
            {
                playerEntity.CriticalHitChance = (specializationAttributes.Intellect + metaData.Level);
            }

            playerEntity.DodgeChance = ((specializationAttributes.Agility / 2) + metaData.Level);
            playerEntity.ParryChange = ((specializationAttributes.Agility / 2.2) + metaData.Level);
            playerEntity.BlockChance = ((specializationAttributes.Agility / 1.8) + metaData.Level);
            playerEntity.ResistChance = ((specializationAttributes.Intellect / 2) + metaData.Level);

            return playerEntity;
        }
    }
}
