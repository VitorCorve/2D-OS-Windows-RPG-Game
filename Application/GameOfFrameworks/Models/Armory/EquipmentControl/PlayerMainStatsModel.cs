
using GameEngine.CombatEngine;

namespace GameOfFrameworks.Models.Armory.EquipmentControl
{
    public class PlayerMainStatsModel
    {
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Energy { get; set; }
        public void SetupModelValues(PlayerEntity playerEntity)
        {
            Health = playerEntity.HealthPoints.Value;
            Mana = playerEntity.ManaPoints.Value;
            Energy = playerEntity.EnergyPoints.Value;
        }
        public void SetupPlayerEntityValues(PlayerEntity playerEntity)
        {
            playerEntity.HealthPoints.Value = Health;
            playerEntity.ManaPoints.Value = Mana;
            playerEntity.EnergyPoints.Value = Energy;
        }
    }
}
