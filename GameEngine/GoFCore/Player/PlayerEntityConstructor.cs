using GameEngine.EquipmentManagement;
using GameEngine.Player;
using GameEngine.Player.Abstract;
using GameEngine.Player.ConditionResources;
using GameEngine.Player.Specializatons.Mage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.CombatEngine
{
    public class PlayerEntityConstructor
    {

        public PlayerEntity CreatePlayer(PlayerGlobalData metaData, IAttributes specializationAttributes, IAttributes equipmentValues)
        {
            var playerEntity = new PlayerEntity
            {
                HealthPoints    = new Health((specializationAttributes.Stamina      + equipmentValues.Stamina) * 10),
                ManaPoints      = new Mana((specializationAttributes.Intellect      + equipmentValues.Intellect) * 10),
                EnergyPoints    = new Energy((specializationAttributes.Agility      + equipmentValues.Agility) * 10),
                AttackPower     = (specializationAttributes.Strength                + equipmentValues.Strength * 10) + equipmentValues.WeaponDamageValue,
                ArmorPoints     = new Armor(equipmentValues.ArmorValue * 10),
                DodgeChance     = (((specializationAttributes.Agility               + equipmentValues.Agility)   / 2)   + metaData.Level),
                ParryChange     = (((specializationAttributes.Agility               + equipmentValues.Agility)   / 2.2) + metaData.Level),
                BlockChance     = (((specializationAttributes.Agility               + equipmentValues.Agility)   / 1.8) + metaData.Level),
                ResistChance    = (((specializationAttributes.Intellect             + equipmentValues.Intellect) / 2)   + metaData.Level),
            };

            switch (specializationAttributes)
            {
                case MageBasicAttributes:
                    playerEntity.CriticalHitChance = 
                        (specializationAttributes.Intellect + metaData.Level);
                    break;
                default:
                    playerEntity.CriticalHitChance = 
                        (specializationAttributes.Agility + metaData.Level);
                    break;
            }

            return playerEntity;
        }
    }
}
