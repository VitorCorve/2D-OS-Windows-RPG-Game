using GameEngine.Equipment;
using GameEngine.MerchantMechanics.Interfaces.Services;
using GameEngine.Player;
using System;

namespace GameEngine.MerchantMechanics.Services
{
    public class BlacksmithingService : IBlacksmithingService
    {
        public int LocationValueMultiplier { get; set; } = 1;
        public bool PermissionToRepair { get; private set; } = false;
        public int RepairCostValue { get; private set; } = 0;
        public PlayerConsumablesData PlayerConsumables { get; private set; }
        public BlacksmithingService(PlayerConsumablesData playerConsumables)
        {
            PlayerConsumables = playerConsumables;
        }
        public WearedEquipment Repair(WearedEquipment equipment)
        {
            RepairCostValue *= LocationValueMultiplier;
            ValidateMoneyValue();

            if (!PermissionToRepair)
                return equipment;

            var durabilityManager = new DurabilityManager();

            RepairCostValue = durabilityManager.CalculateRepairValue(equipment);
            equipment = durabilityManager.RecoverWearedEquipment(equipment);
            Pay();
            return equipment;
        }
        private void ValidateMoneyValue()
        {
            if (PlayerConsumables.AbsoluteMoneyValue >= RepairCostValue)
                PermissionToRepair = true;
            else
                throw new Exception("Not enought money");
        }
        private void Pay()
        {
            PlayerConsumables.AbsoluteMoneyValue -= RepairCostValue;
        }
    }
}
