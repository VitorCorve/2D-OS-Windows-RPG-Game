using GameEngine.CombatEngine;
using GameEngine.Player;
using GameEngine.Player.Abstract;
using GameEngine.Player.Specializatons.Mage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.LevelUpMechanics.Services
{
    public class PlayerLevelUpService
    {
        public IEntityAttributes PlayerAttributes { get; private set; }
        public PlayerConsumablesData PlayerConsumables { get; private set; }
        public PlayerLevelUpService(IEntityAttributes playerAttributes, PlayerModelData playerModel, PlayerConsumablesData playerConsumablesData)
        {
            playerModel.Level += 1;
            PlayerAttributes = playerAttributes;
            PlayerConsumables = playerConsumablesData;
            PlayerConsumables.SkillPointsValue.Value += 1;
        }

        public void UpgradeStrength()
        {
            PlayerAttributes.Strength += 1;
        }

        public void UpgradeStamina()
        {
            PlayerAttributes.Stamina += 1;
        }
        public void UpgradeEndurance()
        {
            PlayerAttributes.Endurance += 1;
        }
        public void UpgradeIntellect()
        {
            PlayerAttributes.Intellect += 1;
        }
        public void UpgradeAgility()
        {
            PlayerAttributes.Agility += 1;
        }
    }
}
