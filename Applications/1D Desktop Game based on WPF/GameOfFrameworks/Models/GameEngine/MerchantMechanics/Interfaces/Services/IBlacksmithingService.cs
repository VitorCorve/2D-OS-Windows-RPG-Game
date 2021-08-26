using GameEngine.Equipment;
using GameEngine.Player;

namespace GameEngine.MerchantMechanics.Interfaces.Services
{
    public interface IBlacksmithingService
    {
        int LocationValueMultiplier { get; }
        bool PermissionToRepair { get; }
        int RepairCostValue { get; }
        PlayerConsumablesData PlayerConsumables { get; }
        WearedEquipment Repair(WearedEquipment equipment);
    }
}
